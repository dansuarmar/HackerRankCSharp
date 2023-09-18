using ApiIntegrationTest.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Validators
{
    public class SwCharacterSearchRequestValidator : AbstractValidator<SwCharacterSearchRequest>
    {
        public SwCharacterSearchRequestValidator()
        {
            RuleFor(request => request.Name).Length(3, 10).WithMessage("Please include 3 to 10 characters to search.");
        }
    }
}
