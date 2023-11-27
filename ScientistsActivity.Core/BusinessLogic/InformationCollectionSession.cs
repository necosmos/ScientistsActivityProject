using ScientistsActivity.Core.Dto;
using ScientistsActivity.Core.Models;

namespace ScientistsActivity.Core.BusinessLogic;

public class InformationCollectionSession
{
    public int TotalSessionSize { get; set; }
    public IDictionary<DataSource, int> DataSourceQueryCounts { get; set; }
    public ParametersDto ParameterWeights { get; set; }

    public InformationCollectionSession(int totalSessionSize, ParametersDto parameterWeights)
    {
        TotalSessionSize = totalSessionSize;
        ParameterWeights = parameterWeights;
        DataSourceQueryCounts = new Dictionary<DataSource, int>();
    }
}
