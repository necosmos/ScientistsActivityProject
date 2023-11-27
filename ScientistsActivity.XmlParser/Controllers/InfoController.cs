using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ScientistsActivity.Core.Dto;
using ScientistsActivity.XmlParser.BusinessLogic;
using ScientistsActivity.XmlParser.Models;

namespace ScientistsActivity.XmlParser.Controllers;

[Route("api/search")]
public class InfoController : Controller
{
    public InfoController(FilterData filterData)
    {
        FilterData = filterData;
    }

    private FilterData FilterData { get; }

    [HttpPost]
    public IActionResult GetFromXml([FromBody] SessionDto dto)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "data.xml");

        var take = dto.Queries * 10;

        WrapModel? data;
        XmlSerializer serializer = new XmlSerializer(typeof(WrapModel));
        using (var reader = new StreamReader(path))
        {
            data = (WrapModel?)serializer.Deserialize(reader);
        }

        if (data is null)
            return BadRequest("Data is null");

        var result = FilterData.Filter(data.Data.Take(take).ToArray(), dto.ParameterWeights);

        var response = new MicroserviceResponseDto
        {
            MaxDataSize = data.Data.Length,
            Queries = dto.Queries,
            ParsedDataSize = take,
            JsonResult = JsonConvert.SerializeObject(result)
        };

        return Ok(response);
    }
}

public class WrapModel
{
    public DataModel[] Data { get; set; } = Array.Empty<DataModel>();
}
