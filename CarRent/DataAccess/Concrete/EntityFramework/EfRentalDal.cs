using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,CarRentContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (CarRentContext context=new CarRentContext())
            {
                var result = from r in context.Rentals
                    join b in context.Brands
                        on r.CarId equals b.Id
                    join cu in context.Customers
                        on r.CustomerId equals cu.UserId
                    select new RentalDetailDto
                    {
                        Id=r.Id,
                        BrandName=b.BrandName,
                        CustomerName =cu.CompanyName,
                        RentDate=r.RentDate,
                        ReturnDate = r.ReturnDate

                    };
                return result.ToList();
            }
        }
    }
}
