using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ScientistsActivity.Core.Dto;
using ScientistsActivity.DatabaseParser.BusinessLogic;
using ScientistsActivity.DatabaseParser.Repository;

namespace ScientistsActivity.DatabaseParser.Controllers;

[ApiController]
[Route("api/search")]
public class InfoController : Controller
{
    public InfoController(IDataRepository dataRepository, FilterData filterData)
    {
        DataRepository = dataRepository;
        FilterData = filterData;
    }

    private IDataRepository DataRepository { get; }
    private FilterData FilterData { get; }

    [HttpPost]
    public async Task<IActionResult> GetInfo([FromBody] SessionDto dto)
    {
        var take = dto.Queries * 10;

        var data = await DataRepository.GetDataAsync(take);

        var result = FilterData.Filter(data, dto.ParameterWeights);

        var response = new MicroserviceResponseDto
        {
            MaxDataSize = data.Count(),
            Queries = dto.Queries,
            ParsedDataSize = take,
            JsonResult = JsonConvert.SerializeObject(result)
        };

        return Ok(response);
    }
}
