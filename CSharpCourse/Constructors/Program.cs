using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1=new Customer{Id = 1,FirstName = "Ayhan",LastName = "Özer",City = "İstanbul"};
            Customer customer2=new Customer(2,"Harun","Özer","İstanbul");
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer2.City);
        }

     
    }

    class Customer
    {
        public Customer()
        {
            
        }

        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
