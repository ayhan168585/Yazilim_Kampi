using System;
using System.Collections.Generic;
using System.Text;
using Castle.Core.Configuration;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.ModelYear).GreaterThan(2014);
            RuleFor(p => p.ModelYear).LessThan(DateTime.Now.Day);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
        }
    }
}
