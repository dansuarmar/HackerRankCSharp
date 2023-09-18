using ApiIntegrationTest.Models;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Services
{
    public interface IStarWarsSearchService
    {
        Task<OneOf<SwCharacterSearchResult, SwCharacterSearchError>> SearchByNameAsync(SwCharacterSearchRequest request);
    }
}
