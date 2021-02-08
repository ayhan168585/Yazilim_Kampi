using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager=new CarManager(new EfCarDal());
           foreach (var car in carManager.GetCarDetails())
           {
               Console.WriteLine(car.Id+" "+car.BrandName+" "+car.ColorName+" "+car.ModelYear+" "+car.DailyPrice+" "+car.Description);
           }
        }
    }
}
