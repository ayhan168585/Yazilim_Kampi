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
          CarManager carManager=new CarManager(new EfCarDal());
          Console.WriteLine("Kiralık Araçların Markası,Rengi,Modeli,Günlük Kirası,Açıklaması");
          Console.WriteLine("------------------------------------------------------------------------");
            foreach (var car in carManager.GetCarDetails())
          {
              Console.WriteLine(car.BrandName+" "+car.ColorName+" "+car.ModelYear+" "+car.DailyPrice+" "+car.Description);
          }
          
        }
    }
}
