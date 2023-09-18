using ApiIntegrationTest.Api.Responses;
using Refit;

namespace ApiIntegrationTest.Api
{
    internal interface IStarWarsApi
    {
        [Get("/people/?search={name}")]
        Task<SwApiCharactersSearchResponse> SearchByNameAsync(string name);
    }
}