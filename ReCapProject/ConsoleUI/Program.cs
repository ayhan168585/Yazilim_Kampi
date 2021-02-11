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
          
            Console.WriteLine("Kiralık Araçların Markası,Rengi,Modeli,Günlük Kirası,Açıklaması");
            Console.WriteLine("------------------------------------------------------------------------");
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);

                }
            }
            else if (result.Success==false)
            {
                Console.WriteLine(result.Message);
            }
           

            Console.WriteLine(carManager.GetCarDetails().Message);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Aşağıdaki 3 komut istenildiğinde açılacak kısım

            //colorManager.Add(new Color{ColorName = "Yeşil"});
            //colorManager.Update(new Color{Id = 1002,ColorName = "Yeşilim"});
            //colorManager.Delete(new Color{Id = 1002});
            Console.WriteLine("Tüm Renk Listesi");
            Console.WriteLine("---------------------------------");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("İstenen Renk");
            Console.WriteLine("---------------------------------");
           
                Console.WriteLine(colorManager.GetById(2).Data.ColorName);
            
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("Tüm Markaların Listesi");
            Console.WriteLine("----------------------------------");
            //Aşağıdaki 3 komut istenildiğinde açılacak kısım

            //brandManager.Add(new Brand{BrandName = "Ferrari"});
            //brandManager.Update(new Brand{Id = 1002,BrandName = "Ferrari"});
            //brandManager.Delete(new Brand{Id = 1002});
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("İstenen Marka");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(brandManager.GetById(2).Data.BrandName);
          
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Aşağıdaki 3 komut istenildiğinde açılacak kısım

            //carManager.Add(new Car{BrandId = 3,ColorId = 4,DailyPrice = 450,ModelYear = 2019,Description = "07.02.2021 'de eklendi."});
            //carManager.Update(new Car{Id = 5,BrandId = 4,ColorId = 3,DailyPrice = 425,ModelYear = 2015,Description = "07.02.2021'de güncellendi."});
            //carManager.Delete(new Car{Id = 5});
            Console.WriteLine("Tüm Araçların Açıklama Kısmı");
            Console.WriteLine("----------------------------------------------");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("İstenen Açıklama Kısmı");
            Console.WriteLine("----------------------------------------------");
           
                Console.WriteLine(carManager.GetById(2).Data.Description);
            

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("İstenen renge göre Açıklama Kısmı");
            Console.WriteLine("----------------------------------------------");
            foreach (var car in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Günlük kirası 300 den düşük olanların açıklama kısmı");
            Console.WriteLine("----------------------------------------------");
            foreach (var car in carManager.GetCarsByDailyPrice(300).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
