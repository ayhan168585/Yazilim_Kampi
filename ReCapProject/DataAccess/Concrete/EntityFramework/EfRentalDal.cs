using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public List<RentDetailDto> GetDetailRental(Expression<Func<Rental, bool>> filter = null)
        {
            
                using (ReCapProjectContext context=new ReCapProjectContext())
                {
                    var result = from r in context.Rentals
                        join ca in context.Cars
                            on r.CarId equals ca.Id
                        join b in context.Brands
                            on ca.BrandId equals b.Id
                        join c in context.Customers
                            on r.CustomerId equals c.UserId
                            join u in context.Users
                                on c.UserId equals u.Id
                                join cr in context.CreditCards
                                    on u.Id equals cr.UserId
                        select new RentDetailDto
                        {
                            Id = r.Id,
                            BrandId = b.Id,
                            BrandName = b.BrandName,
                            CarId = ca.Id,
                            CarName = ca.CarName,
                            UserId = c.UserId,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            CreditCardId = cr.Id,
                            CreditCardUserName = u.FirstName+" "+u.LastName,
                            CustomerId = c.Id,
                            CompanyName = c.CompanyName,
                            RentDate = r.RentDate,
                            ReturnDate = r.ReturnDate
                        };
                    return result.ToList();

                }
            
        }
    }
}
