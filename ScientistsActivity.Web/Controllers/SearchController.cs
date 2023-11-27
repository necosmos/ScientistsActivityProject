using Microsoft.AspNetCore.Mvc;
using ScientistsActivity.Core.BusinessLogic;
using ScientistsActivity.Core.Dto;
using ScientistsActivity.Core.Models;
using ScientistsActivity.Core.Repositories;

namespace ScientistsActivity.Web.Controllers;

[ApiController]
[Route("api/initial")]
public class SearchController : Controller
{
    private const int MaxQueries = 10;

    public SearchController(IInformationCollector informationCollector, IScenarioRepository scenarioRepository)
    {
        InformationCollector = informationCollector;
        ScenarioRepository = scenarioRepository;
    }

    private IInformationCollector InformationCollector { get; }
    private IScenarioRepository ScenarioRepository { get; }

    [HttpPost]
    public async Task<IActionResult> Search([FromBody] ParametersDto task)
    {
        var scenarios = await ScenarioRepository.GetScenarios();

        Scenario scenario = await InformationCollector.ChooseScenario(task, scenarios);

        var session = InformationCollector.CollectInformation(scenario, task, MaxQueries / scenario.DataSources.Count);

        var result = await InformationCollector.GetInformationFromSession(session);

        var maxPercent = result.Max(r => r.Percentage);
        var countMaxPercent = result.Count(r => r.Percentage == maxPercent);

        foreach (var model in result.OrderBy(r => r.Percentage))
        {
            var queries = model.Queries;
            if (queries == 0)
                continue;

            var initial = scenario.InitialProbabilities
                .FirstOrDefault(i => i.SourceName == model.MicroserviceName);

            var count = model.JsonResult.Count;
            var percentage = model.Percentage;

            var usedQueries = scenario.InitialProbabilities.Sum(r => r.Queries);

            if (initial != null)
            {
                if (percentage == 0)
                    queries = 0;

                else if (model.ParsedDataSize < model.MaxDataSize && percentage >= initial.Percentage
                                                                  && count > initial.Quantity)
                {
                    if (usedQueries < MaxQueries)
                        queries++;
                }
                else if (initial.Queries == model.Queries && percentage == initial.Percentage
                                                          && percentage != maxPercent)
                {
                    if (queries > 0)
                        queries--;
                }
                else if (model.ParsedDataSize < model.MaxDataSize && percentage < initial.Percentage
                                                                  && initial.Quantity > count)
                {
                    if (queries > 0)
                        queries--;
                }

                if (maxPercent == percentage && usedQueries < MaxQueries)
                    queries += Math.Max((MaxQueries - usedQueries) / countMaxPercent, 1);

                initial.Quantity = count;
                initial.Percentage = percentage;
                initial.Queries = queries;
            }
            else
            {
                if (percentage == 0)
                    queries = 0;

                if (maxPercent == percentage && usedQueries < MaxQueries)
                    queries += Math.Max((MaxQueries - usedQueries) / countMaxPercent, 1);
                else if (usedQueries < MaxQueries)
                    queries++;

                scenario.InitialProbabilities.Add(new Probabilities
                {
                    SourceName = model.MicroserviceName,
                    Quantity = count,
                    Percentage = percentage,
                    Queries = queries
                });
            }
        }

        await ScenarioRepository.UpdateScenario(scenario);

        var response = result
            .SelectMany(r => r.JsonResult.Select(j => new
            {
                name = r.MicroserviceName,
                result = j
            })).OrderByDescending(r => r.result.Author).ToList();

        var statistic = result.Select(r => new
        {
            name = r.MicroserviceName,
            r.Queries,
            r.ParsedDataSize,
            r.JsonResult.Count,
            r.Percentage
        });

        return Ok(new { statistic, response });
    }
}
