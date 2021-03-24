using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardProcessValidator:AbstractValidator<CreditCardProcess>
    {
        public CreditCardProcessValidator()
        {
            RuleFor(p => p.CreditCardId).NotEmpty();
            RuleFor(p => p.ProcessName).NotEmpty();
            RuleFor(p => p.ProcessName).MinimumLength(2);
            RuleFor(p => p.ProcessName).MaximumLength(200);
            RuleFor(p => p.ProcessPrice).NotEmpty();
            RuleFor(p => p.ProcessPrice).GreaterThanOrEqualTo(0);
        }
    }
}
