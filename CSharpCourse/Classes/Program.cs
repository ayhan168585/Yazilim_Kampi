using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            ProductManager productManager=new ProductManager();
            customerManager.Add();
            customerManager.Update();
            productManager.Add();
            productManager.Update();
            Customer customer=new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Ayhan";
            customer.LastName = "Özer";
            Customer customer2 = new Customer
            {
                Id = 2,City = "İstanbul",FirstName = "Harun",LastName = "Özer"
            };
            Console.WriteLine(customer2.FirstName);
        }
    }

}
