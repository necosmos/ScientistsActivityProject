using Microsoft.EntityFrameworkCore;
using ScientistsActivity.Core.Models;

namespace ScientistsActivity.Core.Repositories;

public class ScenarioRepository : IScenarioRepository
{
    private readonly ApplicationDbContext _context;

    public ScenarioRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Scenario>> GetScenarios()
    {
        return await _context.Scenarios
            .Include(s => s.DataSources)
            .Include(s => s.ParameterWeights)
            .Include(s => s.InitialProbabilities)
            .ToListAsync();
    }

    public async Task AddScenario(Scenario scenario)
    {
        _context.Scenarios.Add(scenario);
        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<DataSource>> GetDataSources()
    {
        return await _context.DataSources.ToListAsync();
    }

    public Task UpdateScenario(Scenario scenario)
    {
        _context.Scenarios.Update(scenario);
        return _context.SaveChangesAsync();
    }
}
