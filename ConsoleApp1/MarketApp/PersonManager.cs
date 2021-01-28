using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp
{
    public class PersonManager
    {
        public void Add(Person person)
        {

            Console.WriteLine("{0} {1} isimli kişi kaydedildi.",person.FirstName,person.LastName);

        }

        public void List(List<Person> personss)
        {
            Console.WriteLine("Liste");
            Console.WriteLine("--------------------------------");
            foreach (var person in personss)
            {
               
                Console.WriteLine(person.Id);
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine("----------------------------");
            }
        }

        public void Delete(int id)
        {
           Console.WriteLine("{0} Id'li kayıt silindi.",id);
        }

    }
}
