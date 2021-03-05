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
            //Data Transformastion Object
            //ProductTest();
            //CategoryTest();
            //ProductManager productManager=new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            //var result = productManager.GetProductDetails();
            //if (result.Success)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + "\t" + product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
           


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //int sayi;
            //ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            //Console.WriteLine("Stokta kaçtan az olan ürünleri görmek istiyorsunuz. :");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}'den az sayıda olan ürünler ", sayi);
            //Console.WriteLine("------------------------------------------------- ");
            //foreach (var product in productManager.GetByUnitsInStock(sayi).Data)
            //{
            //    Console.WriteLine("Ürün Adı : {0}\t Stok sayısı :{1} ", product.ProductName, product.UnitsInStock);
            //}
        }
    }
}
