namespace ScientistsActivity.Core.Models;

public class Probabilities
{
    public int Id { get; set; }

    public string SourceName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public int Queries { get; set; }
    public int Percentage { get; set; }

    public int ScenarioId { get; set; }
    public Scenario Scenario { get; set; } = new();
}
