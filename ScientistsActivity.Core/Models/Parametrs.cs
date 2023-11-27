namespace ScientistsActivity.Core.Models;

public class Parameters
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public double? NameWeight { get; set; }

    public string? Themes { get; set; }
    public double? ThemesWeight { get; set; }

    /// <summary>
    /// Split by comma
    /// </summary>
    public string? KeyWords { get; set; }

    public double? KeyWordsWeight { get; set; }

    public DateTime? Date { get; set; }
    public double? DateWeight { get; set; }

    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public double? RangeWeight { get; set; }

    public int ScenarioId { get; set; }
    public Scenario Scenario { get; set; } = null!;
}
