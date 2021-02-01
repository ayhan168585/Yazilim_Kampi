using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars=new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 230000,ModelYear = 2020,Description = "Yeni Model"},
                new Car{Id = 2,BrandId = 1,ColorId = 2,DailyPrice = 200000,ModelYear = 2019,Description = "Cabrio"},
                new Car{Id = 3,BrandId = 2,ColorId = 1,DailyPrice = 170000,ModelYear = 2016,Description = "Sedan"},
            };
            List<Brand> brands=new List<Brand>
            {
                new Brand{Id = 1,BrandName = "Renault"},
                new Brand{Id = 2,BrandName = "Wolkswagen"},
                new Brand{Id = 3,BrandName = "Mercedes"},
                new Brand{Id = 4,BrandName = "BMV"},
            };
            CarManager carManager=new CarManager(new InMemoryCarDal());
            BrandManager brandManager=new BrandManager(new InMemoryBrandDal());

            var result = from c in cars
                join b in brands
                    on c.BrandId equals b.Id
                select new
                {
                    b.BrandName,
                    c.DailyPrice,
                    c.ModelYear,
                    c.Description
                };
            foreach (var car in result)
            {
                Console.WriteLine("Marka :"+" "+car.BrandName+"\t"+"Fiyatı :"+" "+car.DailyPrice+"\t"+"Model Yılı : "+" "+car.ModelYear+"\t"+"Açıklama"+" "+car.Description);
            }

        }
    }
}
