using ApiIntegrationTest;
using ApiIntegrationTest.Api;
using ApiIntegrationTest.Output;
using ApiIntegrationTest.Services;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Refit;
using System.Text.Json;

namespace MyProject;
class Program
{
    static async Task Main(string[] args)
    {
        IConfigurationRoot configuration = BuildConfiguration();
        ServiceProvider serviceProvider = BuildServiceProvider(configuration);
        //var client = serviceProvider.GetRequiredService<IStarWarsApi>();
        //var response = await client.SearchByName("luke");
        //var responseText = JsonSerializer.Serialize(response, new JsonSerializerOptions
        //{
        //    WriteIndented = true
        //});
        //Console.WriteLine(responseText);

        var app = serviceProvider.GetRequiredService<StarWarsSearchApplication>();
        await app.RunAsync(args);
    }

    private static ServiceProvider BuildServiceProvider(IConfigurationRoot configuration)
    {
        var services = new ServiceCollection();
        ConfigureServices(services, configuration);

        var serviceProvider = services.BuildServiceProvider();
        return serviceProvider;
    }

    private static void ConfigureServices(ServiceCollection services, IConfigurationRoot configuration)
    {
        services.AddSingleton<StarWarsSearchApplication>();
        services.AddSingleton<IConsoleWriter, ConsoleWriter>();
        services.AddSingleton<IStarWarsSearchService, StarWarsSearchService>();
        services.AddValidatorsFromAssemblyContaining<Program>();
        services.AddRefitClient<IStarWarsApi>()
            .AddTransientHttpErrorPolicy(builder =>
                builder.WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(5),
                    TimeSpan.FromSeconds(10),
                }))
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri(configuration["StarWarsApi:BaseAddress"]!);
            });
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    }
}