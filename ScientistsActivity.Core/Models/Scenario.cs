using ScientistsActivity.Core.BusinessLogic;

namespace ScientistsActivity.Core.Models;

public class Scenario
{
    public int Id { get; set; }

    public int TotalSessionSize { get; set; }
    public Parameters? ParameterWeights { get; set; }

    public ICollection<Probabilities> InitialProbabilities { get; set; } = new List<Probabilities>();

    public ICollection<DataSource> DataSources { get; set; } = new List<DataSource>();
}
