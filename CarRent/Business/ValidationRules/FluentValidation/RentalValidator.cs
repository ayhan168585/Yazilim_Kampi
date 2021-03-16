using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.CustomerId).NotEmpty();
            RuleFor(p => p.RentDate).NotEmpty();
            RuleFor(p => p.RentDate).LessThan(DateTime.Now);
            RuleFor(p => p.RentDate).GreaterThan(p=>p.ReturnDate);
            RuleFor(p => p.ReturnDate).NotEmpty();
            RuleFor(p => p.ReturnDate).LessThan(DateTime.Now);
            RuleFor(p => p.ReturnDate).LessThan(p=>p.RentDate);
        }
    }
}
