using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(p => p.BrandName).NotEmpty();
            RuleFor(p => p.BrandName).MinimumLength(2);
            RuleFor(p => p.BrandName).MaximumLength(50);

        }
    }
}
