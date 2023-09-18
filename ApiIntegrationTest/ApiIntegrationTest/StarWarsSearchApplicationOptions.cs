
using CommandLine;

namespace ApiIntegrationTest
{
    internal class StarWarsSearchApplicationOptions
    {
        [Option('n', "Name", Required = true, HelpText = "Set the character name to search for.")]
        public string Name { get; init; }
    }
}