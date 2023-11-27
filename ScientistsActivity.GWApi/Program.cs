using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
RegisterServices(builder.Services);

var app = builder.Build();

builder.Configuration.AddJsonFile("ocelotConfiguration.json", optional: false, reloadOnChange: true);

Configure(app);

app.Run();
return;

void RegisterServices(IServiceCollection services)
{
    services.AddOcelot(builder.Configuration);
    services.AddControllers();
}

async void Configure(IApplicationBuilder appBuilder)
{
    appBuilder.UseRouting();
    appBuilder.UseCors(con => con.WithOrigins("https://localhost:44465")
        .AllowAnyHeader().AllowAnyMethod().AllowCredentials());
    appBuilder.UseEndpoints(endpoints =>
    {
        endpoints.MapGet("/", async context => { await context.Response.WriteAsync("API Gateway started"); });
    });
    await appBuilder.UseOcelot();
}
