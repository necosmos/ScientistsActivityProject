using ScientistsActivity.DatabaseParser.Models;

namespace ScientistsActivity.DatabaseParser.Repository;

public interface IDataRepository
{
    Task<IEnumerable<DataModel>> GetDataAsync(int take);
}
