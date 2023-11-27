using ScientistsActivity.Core.Models;

namespace ScientistsActivity.Core.Repositories;

public interface IScenarioRepository
{
    Task<IEnumerable<Scenario>> GetScenarios();
    Task AddScenario(Scenario scenario);
    Task<ICollection<DataSource>> GetDataSources();
    Task UpdateScenario(Scenario scenario);
}
