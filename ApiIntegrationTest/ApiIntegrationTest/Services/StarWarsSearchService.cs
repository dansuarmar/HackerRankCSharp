using ApiIntegrationTest.Api;
using ApiIntegrationTest.Mapping;
using ApiIntegrationTest.Models;
using FluentValidation;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Services
{
    internal class StarWarsSearchService : IStarWarsSearchService
    {
        private readonly IStarWarsApi _starwarsApi;
        private readonly IValidator<SwCharacterSearchRequest> _validator;
        public StarWarsSearchService(IStarWarsApi starwarsApi, IValidator<SwCharacterSearchRequest> validator)
        {
            _starwarsApi = starwarsApi; 
            _validator = validator;
        }

        public async Task<OneOf<SwCharacterSearchResult, SwCharacterSearchError>> SearchByNameAsync(SwCharacterSearchRequest request)
        {
            var validatorResult = _validator.Validate(request);
            if(!validatorResult.IsValid) 
            {
                var errorMsg = validatorResult.Errors.Select(x => x.ErrorMessage).ToList();
                return new SwCharacterSearchError(errorMsg);
            }

            var response = await _starwarsApi.SearchByNameAsync(request.Name);
            return new SwCharacterSearchResult()
            {
                Count = response.Count,
                Characters = response.Characters.Select(x => x.ToSwCharacterResult()).ToList(),
            };
        }
    }
}
