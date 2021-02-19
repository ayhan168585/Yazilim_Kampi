using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Email).MinimumLength(2);
            RuleFor(p => p.Email).MaximumLength(50);
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MinimumLength(4);
            RuleFor(p => p.Password).MaximumLength(20);
            
        }
    }
}
