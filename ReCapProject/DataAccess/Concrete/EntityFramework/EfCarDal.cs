using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in filter==null ? context.Cars:context.Cars.Where(filter)
                    join b in context.Brands on c.BrandId equals b.Id
                    join co in context.Colors on c.ColorId equals co.Id
                    //join ci in context.CarImages on c.Id equals ci.CarId
                    select new CarDetailDto
                    {
                        CarId = c.Id,
                        BrandId = c.BrandId,
                        ColorId = c.ColorId,
                        BrandName = b.BrandName,
                        ColorName = co.ColorName,
                        CarName = c.CarName,
                        ModelYear = c.ModelYear,
                        DailyPrice = c.DailyPrice,
                        //ImagePath = ci.ImagePath,
                        Description = c.Description
                    };
                return result.ToList();

            }
        }
    }
}
