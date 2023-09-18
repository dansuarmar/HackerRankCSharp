using ApiIntegrationTest.Api.Responses;
using ApiIntegrationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Mapping
{
    public static class ContractToDomainMapping
    {
        public static SwCharacterResult ToSwCharacterResult(this SwApiCharacterResponse response) 
        {
            return new SwCharacterResult()
            {
                Name = response.Name,
                Height = response.Height,
                Films = response.Films.Select(x => new Uri(x)).ToList(),
            };
        }
    }
}
