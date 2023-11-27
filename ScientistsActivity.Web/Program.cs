using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ScientistsActivity.Core;
using ScientistsActivity.Core.AutoMapperProfile;
using ScientistsActivity.Core.BusinessLogic;
using ScientistsActivity.Core.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("TargetMicroservice", client => client.BaseAddress = new Uri("http://localhost:5273/"));

builder.Services.AddScoped<IInformationCollector, InformationCollector>();
builder.Services.AddScoped<IScenarioRepository, ScenarioRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("name=Data:ConnectionString"));

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        options.SerializerSettings.Converters.Add(new StringEnumConverter());
    });
builder.Services.AddAutoMapper(typeof(ParameterProfile));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
