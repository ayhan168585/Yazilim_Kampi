using System;
using System.Collections.Generic;

namespace MarketApp
{
    public class Program
    {

        public static void Main(string[] args)
        {

            string secim;
            int menuSec = 0;
            int araSecim = 0;
            int listAraSEcim = 0;
            int silAraSecim = 0;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("O   U   R     M    A    R    K   E    T");
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("\n\n\n");

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("İşlemler Menüsü");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1- Ekleme İşlemleri");
                Console.WriteLine("2- Listeleme İşlemleri");
                Console.WriteLine("3- Silme İşlemleri");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Yapılacak işlemi seçiniz");
                try
                {
                    menuSec = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e);
                    Console.WriteLine("Lütfen sayı giriniz.");
                   
                }
               

                if (menuSec == 1)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Ekleme İşlemleri Bölümü");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1- Satış Elemanı Ekleme");
                    Console.WriteLine("2- Müşteri Ekleme");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Yapılacak işlemi seçiniz");
                    try
                    {
                        araSecim = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine(e);
                        Console.WriteLine("Lütfen sayı giriniz.");
                        
                    }
                   
                    if (araSecim == 1)
                    {
                        SalesPerson person1 = new SalesPerson();
                        try
                        {
                            Console.WriteLine("ID Giriniz :");
                            person1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Satış Elemanı Adı Giriniz :");
                            person1.FirstName = Console.ReadLine();
                            Console.WriteLine("Satış Elemanı Soyadı Giriniz  :");
                            person1.LastName = Console.ReadLine();
                            Console.WriteLine("Personel Numarası Giriniz :");
                            person1.PersonelNumber = Console.ReadLine();
                            PersonManager personManager = new PersonManager();
                            personManager.Add(person1);
                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e);
                            Console.WriteLine("Lütfen sayı giriniz.");
                           
                        }


                       

                    }

                    else if (araSecim == 2)
                    {
                        Customer customer = new Customer();
                        try
                        {
                            Console.WriteLine("ID Giriniz :");
                            customer.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Müşteri Adı Giriniz :");
                            customer.FirstName = Console.ReadLine();
                            Console.WriteLine("Müşteri Soyadı Giriniz  :");
                            customer.LastName = Console.ReadLine();
                            Console.WriteLine("Müşteri Adresi Giriniz :");
                            customer.Adress = Console.ReadLine();
                            PersonManager personManager = new PersonManager();
                            personManager.Add(customer);
                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e);
                            Console.WriteLine("Lütfen sayı giriniz.");

                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    }

                }

                else if (menuSec==2)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Listeleme İşlemleri Bölümü");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("1- Satış Elemanı Listeleme");
                    Console.WriteLine("2- Müşteri Listeleme");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Yapılacak işlemi seçiniz");
                    Console.WriteLine("-----------------------------");
                    try
                    {
                        listAraSEcim = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine(e);
                        Console.WriteLine("Lütfen sayı giriniz.");
                    }
                   
                    Console.WriteLine("-----------------------------");
                    if (listAraSEcim==1)
                    {
                        SalesPerson person1=new SalesPerson{Id = 1,FirstName = "Ayhan",LastName = "Özer",PersonelNumber = "P1"};
                        SalesPerson person2=new SalesPerson{Id = 2,FirstName = "Harun",LastName = "Özer",PersonelNumber = "P2"}; 
                        List<Person> persons=new List<Person>(){person1,person2};
                        PersonManager personManager=new PersonManager();
                        personManager.List(persons);
                        
                    }
                    else if (listAraSEcim == 2)
                    {
                        Customer customer1 = new Customer { Id = 3, FirstName = "Hasan", LastName = "Acar", Adress = "Bostancı" };
                        Customer customer2 = new Customer { Id = 4, FirstName = "Ali", LastName = "Acar", Adress = "Edirne" };
                        List<Person> customers = new List<Person>() { customer1, customer2 };
                        PersonManager personManager = new PersonManager();
                        personManager.List(customers);

                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    }
                }
                else if (menuSec==3)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Silme İşlemleri Bölümü");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("1- Satış Elemanı Silme");
                    Console.WriteLine("2- Müşteri Silme");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Yapılacak işlemi seçiniz");
                    Console.WriteLine("-----------------------------");
                    try
                    {
                        silAraSecim = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine(e);
                        Console.WriteLine("Lütfen sayı giriniz.");
                    }
                    Console.WriteLine("-----------------------------");
                    if (silAraSecim == 1)
                    {
                        SalesPerson person1 = new SalesPerson { Id = 1, FirstName = "Ayhan", LastName = "Özer", PersonelNumber = "P1" };
                        SalesPerson person2 = new SalesPerson { Id = 2, FirstName = "Harun", LastName = "Özer", PersonelNumber = "P2" };

                       List<Person> persons=new List<Person>(){person1,person2};

                       foreach (var person in persons)
                       {
                           Console.WriteLine("ID :"+person.Id+"\t"+person.FirstName+" "+person.LastName);
                       }

                       Console.WriteLine("-------------------------------");
                       Console.WriteLine("Silinecek ID giriniz");
                       try
                       {
                           int id = Convert.ToInt32(Console.ReadLine());
                           PersonManager personManager = new PersonManager();

                           personManager.Delete(id);
                        }
                       catch (Exception e)
                       {
                           //Console.WriteLine(e);
                           Console.WriteLine("Lütfen sayı giriniz.");
                          
                       }
                       
                        
                       
                    }
                    else if (silAraSecim == 2)
                    {
                        Customer customer1 = new Customer { Id = 3, FirstName = "Hasan", LastName = "Acar", Adress = "Bostancı" };
                        Customer customer2 = new Customer { Id = 4, FirstName = "Ali", LastName = "Acar", Adress = "Edirne" };
                        List<Person> customers = new List<Person>() { customer1, customer2 };

                        foreach (var customer in customers)
                        {
                            Console.WriteLine("ID :" + customer.Id + "\t" + customer.FirstName + " " + customer.LastName);
                        }

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Silinecek ID giriniz");
                        try
                        {
                            int id = Convert.ToInt32(Console.ReadLine());
                            PersonManager personManager = new PersonManager();

                            personManager.Delete(id);
                        }
                        catch (Exception e)
                        {
                            //Console.WriteLine(e);
                            Console.WriteLine("Lütfen sayı giriniz.");

                        }



                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                }



                Console.WriteLine("Devam etmek istiyormusunuz.(E/H)");
                secim = Console.ReadLine();
            } while (secim == "E" || secim == "e");
        }
    }
}
