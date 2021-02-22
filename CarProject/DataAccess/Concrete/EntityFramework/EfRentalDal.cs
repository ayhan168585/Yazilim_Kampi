using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,CarProjectContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (CarProjectContext context=new CarProjectContext())
            {
                var result = from r in context.Rentals
                    join b in context.Brands
                        on r.CarId equals b.Id
                    join c in context.Customers
                        on r.CustomerId equals c.UserId
                    select new RentalDetailDto
                    {
                        Id = r.Id,
                        BrandName = b.BrandName,
                        CustomerName = c.CompanyName,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}
