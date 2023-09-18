using ApiIntegrationTest.Models;
using ApiIntegrationTest.Output;
using ApiIntegrationTest.Services;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiIntegrationTest
{
    public class StarWarsSearchApplication
    {
        private readonly IConsoleWriter _console;
        private readonly IStarWarsSearchService _starwarsSearchService;
        public StarWarsSearchApplication(IConsoleWriter console, IStarWarsSearchService starWarsSearchService)
        {
            _console = console;
            _starwarsSearchService = starWarsSearchService;
        }

        public async Task RunAsync(string[] args)
        {
            await Parser.Default.ParseArguments<StarWarsSearchApplicationOptions>(args)
                .WithParsedAsync(async option =>
                {
                    var searchRequest = new SwCharacterSearchRequest(option.Name);
                    var result = await _starwarsSearchService.SearchByNameAsync(searchRequest);

                    result.Switch(searchResult =>
                    {
                        var formatedTextResult = JsonSerializer.Serialize(searchResult, new JsonSerializerOptions()
                        {
                            WriteIndented = true,
                        });
                        _console.WriteLine($"The Character name is {option.Name}");
                        _console.WriteLine($"The number of results is { searchResult.Count }");
                        _console.WriteLine(formatedTextResult);
                    }, error =>
                    {
                        var formattedErrors = string.Join(", ", error.Errors);
                        Console.WriteLine(formattedErrors);
                    });

                });
        }

    }
}
