using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager=new CarManager(new EfCarDal());
           carManager.Update(new Car{Id = 6,BrandId = 4,ColorId = 1,ModelYear = 1990,DailyPrice = 50,Description = "Antika"});
           foreach (var car in carManager.GetCarDetails())
           {
               Console.WriteLine(car.Id+" "+car.BrandName+" "+car.ColorName+" "+car.ModelYear+" "+car.DailyPrice+" "+car.Description);
           }

           Console.WriteLine("-------------------------------------------------------");
           Console.WriteLine(carManager.Get(2).Description);
           ;

        }
    }
}
