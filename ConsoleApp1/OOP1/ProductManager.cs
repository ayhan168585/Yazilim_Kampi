using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
     
    }
}
