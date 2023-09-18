using System.Text.Json.Serialization;

namespace ApiIntegrationTest.Api.Responses
{
    public record SwApiCharacterResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; init; }

        [JsonPropertyName("height")]
        public string Height { get; init; }

        [JsonPropertyName("mass")]
        public string Mass { get; init; }

        [JsonPropertyName("created")]
        public DateTime Created { get; init; }

        [JsonPropertyName("films")]
        public IReadOnlyList<string> Films { get; set; }
    }
}