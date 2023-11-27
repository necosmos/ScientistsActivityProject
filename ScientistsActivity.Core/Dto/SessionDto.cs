namespace ScientistsActivity.Core.Dto;

public class SessionDto
{
    public ParametersDto ParameterWeights { get; set; } = new();
    public int Queries { get; set; }
}
