using ScientistsActivity.GoogleSearch.BusinessLogic;

namespace ScientistsActivity.GoogleSearch;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddScoped<FilterData>();

        var app = builder.Build();

        app.UseDefaultFiles();
        app.UseStaticFiles();
        app.UseDeveloperExceptionPage();
        app.MapControllers();

        app.Run();
    }
}
