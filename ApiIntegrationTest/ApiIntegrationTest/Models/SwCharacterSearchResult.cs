using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Models
{
    public record SwCharacterSearchResult
    {
        public int Count { get; init; }
        public IReadOnlyList<SwCharacterResult> Characters { get; init; }
    }
}
