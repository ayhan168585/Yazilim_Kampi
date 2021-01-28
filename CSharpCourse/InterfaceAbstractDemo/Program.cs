using System;
using System.Reflection.PortableExecutable;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager=new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer {DateOfBirth=new DateTime(1969,8,24),FirstName = "Ayhan",LastName = "Özer",NationalityId = "11999591936"} );

        }
    }
}
