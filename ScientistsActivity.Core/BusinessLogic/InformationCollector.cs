using System.Text;
using AutoMapper;
using Newtonsoft.Json;
using ScientistsActivity.Core.Dto;
using ScientistsActivity.Core.Models;
using ScientistsActivity.Core.Repositories;

namespace ScientistsActivity.Core.BusinessLogic;

public interface IInformationCollector
{
    Task<Scenario> ChooseScenario(ParametersDto task, IEnumerable<Scenario> scenarios);

    InformationCollectionSession CollectInformation(Scenario scenario, ParametersDto parameterWeights,
        int initialQueries);

    Task<List<ResultModelDto>> GetInformationFromSession(InformationCollectionSession scenario);
}

public class InformationCollector : IInformationCollector
{
    private readonly IHttpClientFactory _httpClientFactory;

    public InformationCollector(IHttpClientFactory httpClientFactory, IScenarioRepository scenarioRepository,
        IMapper mapper)
    {
        _httpClientFactory = httpClientFactory;
        ScenarioRepository = scenarioRepository;
        Mapper = mapper;
    }

    private IScenarioRepository ScenarioRepository { get; }
    private IMapper Mapper { get; }

    public async Task<Scenario> ChooseScenario(ParametersDto task, IEnumerable<Scenario> scenarios)
    {
        if (scenarios.Any())
        {
            var defaultScenario = scenarios
                .FirstOrDefault(s => s.ParameterWeights != null && IsDefaultScenario(s.ParameterWeights, task));

            if (defaultScenario is not null)
                return defaultScenario;
        }

        var scenario = new Scenario
        {
            DataSources = await ScenarioRepository.GetDataSources(),
            ParameterWeights = Mapper.Map<Parameters>(task)
        };

        await ScenarioRepository.AddScenario(scenario);

        return scenario;
    }

    public InformationCollectionSession CollectInformation(Scenario scenario, ParametersDto parameterWeights,
        int initialQueries)
    {
        var session = new InformationCollectionSession(scenario.TotalSessionSize, parameterWeights);

        foreach (var dataSource in scenario.DataSources)
        {
            var probability = scenario.InitialProbabilities
                .FirstOrDefault(p => p.SourceName == dataSource.Name);

            var queries = probability?.Queries ?? initialQueries;

            session.DataSourceQueryCounts.Add(dataSource, queries);
        }

        return session;
    }

    public async Task<List<ResultModelDto>> GetInformationFromSession(InformationCollectionSession session)
    {
        var httpClient = _httpClientFactory.CreateClient("TargetMicroservice");

        var data = new List<ResultModelDto>();
        foreach (var (key, value) in session.DataSourceQueryCounts)
        {
            var sessionDto = new SessionDto
            {
                Queries = value,
                ParameterWeights = session.ParameterWeights
            };

            var content = new StringContent(JsonConvert.SerializeObject(sessionDto), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"api/{key.Endpoint}/search", content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var resultModel = JsonConvert.DeserializeObject<MicroserviceResponseDto>(responseData);

                data.Add(new ResultModelDto
                {
                    MicroserviceName = key.Name,
                    MaxDataSize = resultModel!.MaxDataSize,
                    Queries = resultModel.Queries,
                    ParsedDataSize = resultModel.ParsedDataSize,
                    JsonResult = JsonConvert.DeserializeObject<ICollection<ResultDto>>(resultModel.JsonResult)!
                });
            }
            else
                Console.WriteLine($"Error: {response.StatusCode}");
        }

        return data;
    }

    private static bool IsDefaultScenario(Parameters parameters, ParametersDto task)
    {
        if (task.Name != parameters.Name)
            return false;

        if (task.Themes != parameters.Themes)
            return false;

        if (task.KeyWords != parameters.KeyWords)
            return false;

        if (task.Date != parameters.Date)
            return false;

        if (task.From != parameters.From)
            return false;

        if (task.To != parameters.To)
            return false;

        return true;
    }
}
