using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,ReCapProjectContext>,IRentalDal
    {
        public List<RentDetailDto> GetDetailRental()
        {
            
                using (ReCapProjectContext context=new ReCapProjectContext())
                {
                    var result = from r in context.Rentals
                        join b in context.Brands
                            on r.CarId equals b.Id
                        join c in context.Customers
                            on r.CustomerId equals c.UserId
                        select new RentDetailDto
                        {
                            Id = r.Id,
                            BrandName = b.BrandName,
                            CompanyName = c.CompanyName,
                            RentDate = r.RentDate,
                            ReturnDate = r.ReturnDate
                        };
                    return result.ToList();

                }
            
        }
    }
}
