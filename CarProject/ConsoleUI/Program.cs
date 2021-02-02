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
            List<Car> cars = new List<Car>
           {
               new Car{Id = 1,BrandId = 1,ColorId = 1,ModelYear = 2019,DailyPrice = 150000,Description ="Sedan Araç" },
               new Car{Id = 2,BrandId = 1,ColorId = 2,ModelYear = 2020,DailyPrice = 200000,Description ="Cabrio" },
               new Car{Id = 3,BrandId = 2,ColorId = 3,ModelYear = 2021,DailyPrice = 250000,Description ="Yeni Model" }
           };
            List<Brand> brands = new List<Brand>
           {
               new Brand{Id = 1,BrandName = "Renault"},
               new Brand{Id = 2,BrandName = "Wolkswagen"},
               new Brand{Id = 3,BrandName = "Mercedes"},
               new Brand{Id = 4,BrandName = "BMV"},
           };
            List<Color> colors = new List<Color>
           {
               new Color{Id = 1,ColorName = "Beyaz"},
               new Color{Id = 2,ColorName = "Siyah"},
               new Color{Id = 3,ColorName = "Kırmızı"},
           };


            
            var result = (from c in cars
                          join b in brands
                              on c.BrandId equals b.Id
                          join co in colors
                              on c.ColorId equals co.Id
                          select new CarDTO()
                          {
                              BrandName = b.BrandName,
                              ColorName = co.ColorName,
                              ModelYear = c.ModelYear,
                              DailyPrice = c.DailyPrice,
                              Description = c.Description
                          }).ToList();
            foreach (var car in result)
            {
                Console.WriteLine("Marka :" + " " + car.BrandName + "\t" + "Rengi :" + " " + car.ColorName + "\t" + "Fiyatı :" + " " + car.DailyPrice + "\t" + "Model Yılı : " + " " + car.ModelYear + "\t" + "Açıklama" + " " + car.Description);
            }
        }
    }
}
