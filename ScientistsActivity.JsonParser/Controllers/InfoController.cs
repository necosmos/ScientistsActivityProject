using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ScientistsActivity.Core.BusinessLogic;
using ScientistsActivity.Core.Dto;
using ScientistsActivity.JsonParser.BusinessLogic;
using ScientistsActivity.JsonParser.Models;

namespace ScientistsActivity.JsonParser.Controllers;

[Route("api/search")]
public class InfoController : Controller
{
    public InfoController(FilterData filterData)
    {
        FilterData = filterData;
    }

    private FilterData FilterData { get; }

    [HttpPost]
    public IActionResult GetFromJson([FromBody] SessionDto dto)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "data.json");
        var json = System.IO.File.ReadAllText(path);

        var take = dto.Queries * 10;

        var data = JsonConvert.DeserializeObject<DataModel[]>(json);
        if (data is null)
            return BadRequest("Data is null");

        data = data.Take(take).ToArray();
        var result = FilterData.Filter(data, dto.ParameterWeights);

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
