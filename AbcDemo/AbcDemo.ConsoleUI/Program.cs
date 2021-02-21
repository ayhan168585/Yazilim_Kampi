using System;
using AbcDemo.Business.Abstract;
using AbcDemo.Business.Concrete;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using DataAccess.Concrete.EntityFramework;

namespace AbcDemo.ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IProductService productService=new ProductManager(new EfProductDal());
            foreach (var product in productService.GetAll())
            {
                
                Console.WriteLine(product.Name);
            }

           
        }
    }
}
