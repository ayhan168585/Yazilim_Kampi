﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarRentContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarRentContext context=new CarRentContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join co in context.Colors
                        on c.ColorId equals co.Id
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.BrandName,
                        ColorName = co.ColorName,
                        ModelYear = c.ModelYear,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }
    }
}
