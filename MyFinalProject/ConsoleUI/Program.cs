using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("Stokta kaçtan az olan ürünleri görmek istiyorsunuz. :");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}'den az sayıda olan ürünler ",sayi);
            Console.WriteLine("------------------------------------------------- ");
            foreach (var product in productManager.GetByUnitsInStock(sayi))
            {

                Console.WriteLine("Ürün Adı : {0}\t Stok sayısı :{1} ",product.ProductName,product.UnitsInStock);
            }
        }
    }
}
