using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            CarManager carManager=new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
        }

        private static void ColorTest()
        {
            Console.WriteLine("Yeni Renk Ekleme");
            Console.WriteLine("------------------------------------------------------------------------");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Delete(new Color {Id = 1003});
            Console.WriteLine("Tüm Renklerin Listesi");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Id + " " + color.ColorName);
            }
        }

        private static void BrandTest()
        {
            Console.WriteLine("Yeni Marka Ekleme");
            Console.WriteLine("------------------------------------------------------------------------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Delete(new Brand {Id = 1005});
            Console.WriteLine("Tüm Markaların Listesi");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Id + " " + brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Kiralık Araçların Markası,Rengi,Modeli,Günlük Kirası,Açıklaması");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
        }
    }
}
