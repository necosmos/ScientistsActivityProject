namespace ScientistsActivity.Core.Models;

public class DataSource
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Endpoint { get; set; } = string.Empty;

    public ICollection<Scenario> Scenarios { get; set; } = new List<Scenario>();
}
