using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardValidator:AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(p => p.BankId).NotEmpty();
            RuleFor(p => p.CreditCardNumber).NotEmpty();
            RuleFor(p => p.CreditCardNumber).MinimumLength(2);
            RuleFor(p => p.CreditCardNumber).MaximumLength(50);
            RuleFor(p => p.CreditCardDeposit).NotEmpty();
            RuleFor(p => p.CreditCardDeposit).GreaterThanOrEqualTo(0);
        }
    }
}
