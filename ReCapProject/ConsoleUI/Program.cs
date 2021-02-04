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
           Console.WriteLine("Tüm Araçların Açıklama Kısmı");
           Console.WriteLine("----------------------------------------------");
           foreach (var car in carManager.GetAll())
           {
               Console.WriteLine(car.Description);
           }
           Console.WriteLine("----------------------------------------------");
           Console.WriteLine("İstenen markaya göre Açıklama Kısmı");
            Console.WriteLine("----------------------------------------------");
           foreach (var car in carManager.GetCarsByBrandId(2))
           {
               Console.WriteLine(car.Description);
           }
           Console.WriteLine("----------------------------------------------");
           Console.WriteLine("İstenen renge göre Açıklama Kısmı");
           Console.WriteLine("----------------------------------------------");
           foreach (var car in carManager.GetCarsByColorId(3))
           {
               Console.WriteLine(car.Description);
           }
           Console.WriteLine("----------------------------------------------");
           Console.WriteLine("Günlük kirası 300 den düşük olanların açıklama kısmı");
           Console.WriteLine("----------------------------------------------");
           foreach (var car in carManager.GetCarsByDailyPrice(300))
           {
               Console.WriteLine(car.Description);
           }
        }
    }
}
