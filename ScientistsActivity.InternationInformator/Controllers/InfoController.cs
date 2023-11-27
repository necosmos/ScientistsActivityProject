using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ScientistsActivity.Core.Dto;
using ScientistsActivity.InternationalInformation.BusinessLogic;

namespace ScientistsActivity.InternationalInformation.Controllers;

[Route("api/search")]
public class InfoController : Controller
{
    public InfoController(FilterData filterData)
    {
        FilterData = filterData;
    }

    private FilterData FilterData { get; }

    [HttpPost]
    public IActionResult GetFromObject([FromBody] SessionDto dto)
    {
        var data = Data.Get();
        var take = dto.Queries * 10;

        if (data is null)
            return BadRequest("Data is null");

        var result = FilterData.Filter(data.Take(take).ToArray(), dto.ParameterWeights);

        var response = new MicroserviceResponseDto
        {
            MaxDataSize = data.Length,
            Queries = dto.Queries,
            ParsedDataSize = take,
            JsonResult = JsonConvert.SerializeObject(result)
        };

        return Ok(response);
    }
}
