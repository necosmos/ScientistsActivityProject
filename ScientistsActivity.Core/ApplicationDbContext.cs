using Microsoft.EntityFrameworkCore;
using ScientistsActivity.Core.Models;

namespace ScientistsActivity.Core;

public class ApplicationDbContext : DbContext
{
    public DbSet<Scenario> Scenarios { get; set; } = null!;
    public DbSet<DataSource> DataSources { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<DataSource>()
            .HasData(new List<DataSource>
            {
                new() { Id = 1, Name = "Json Parses", Endpoint = "json" },
                new() { Id = 2, Name = "Database Parses", Endpoint = "database" },
                new() { Id = 3, Name = "Internation Parses", Endpoint = "internation" },
                new() { Id = 4, Name = "Google Parses", Endpoint = "google" },
                new() { Id = 5, Name = "Xml Parses", Endpoint = "xml" }
            });
    }
}
