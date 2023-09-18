using System.Text.Json.Serialization;

namespace ApiIntegrationTest.Api.Responses
{
    public record SwApiCharactersSearchResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; init; }

        [JsonPropertyName("results")]
        public IReadOnlyList<SwApiCharacterResponse> Characters { get; init; }
    }
}