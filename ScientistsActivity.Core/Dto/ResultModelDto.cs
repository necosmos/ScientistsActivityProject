namespace ScientistsActivity.Core.Dto;

public class ResultModelDto
{
    public int MaxDataSize { get; set; }
    public int Queries { get; set; }
    public int ParsedDataSize { get; set; }
    public string MicroserviceName { get; set; } = null!;
    public int Percentage => ParsedDataSize == 0 ? 0 : JsonResult.Count * 100 / ParsedDataSize;
    public ICollection<ResultDto> JsonResult { get; set; } = new List<ResultDto>();
}
