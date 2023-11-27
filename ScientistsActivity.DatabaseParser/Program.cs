using Microsoft.EntityFrameworkCore;
using ScientistsActivity.DatabaseParser;
using ScientistsActivity.DatabaseParser.BusinessLogic;
using ScientistsActivity.DatabaseParser.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseDbContext>(options =>
    options.UseSqlServer("name=Data:ConnectionString"));

builder.Services.AddControllers();
builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddScoped<FilterData>();

var app = builder.Build();

app.MapControllers();

app.Run();
