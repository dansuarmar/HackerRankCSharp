using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Models
{
    public record SwCharacterSearchError
    {
        public SwCharacterSearchError(IReadOnlyList<string> errorMessages)
        {
            Errors = errorMessages;
        }

        public IReadOnlyList<string> Errors { get; }
    }
}
