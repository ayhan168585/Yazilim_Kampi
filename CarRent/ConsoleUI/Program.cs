using System;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            RentalManager rentalManager=new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetail();
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.CustomerName+" "+rental.BrandName+" "+rental.RentDate+" "+rental.ReturnDate);
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(Messages.RentalListed);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetail();

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.ModelYear + " " + car.DailyPrice + " " +
                                  car.Description);
            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(Messages.CarListed);
        }
    }
}
