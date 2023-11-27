namespace ScientistsActivity.Core.Dto;

public class MicroserviceResponseDto
{
    public int MaxDataSize { get; set; }
    public int Queries { get; set; }
    public int ParsedDataSize { get; set; }

    public string JsonResult { get; set; } = null!;
}
