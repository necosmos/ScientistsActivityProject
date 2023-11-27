using Microsoft.EntityFrameworkCore;
using ScientistsActivity.DatabaseParser.Models;

namespace ScientistsActivity.DatabaseParser.Repository;

public class DataRepository : IDataRepository
{
    private readonly DatabaseDbContext _context;

    public DataRepository(DatabaseDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DataModel>> GetDataAsync(int take)
    {
        return await _context.DataModels.Take(take).ToListAsync();
    }
}
