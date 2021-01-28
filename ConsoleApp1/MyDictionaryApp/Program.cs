using System;
using System.Collections.Generic;
using System.Dynamic;

namespace MyDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int id=0;
            string kayit;
            string devam=null;
            Console.WriteLine("Öğrenci listesi");
            Console.WriteLine("----------------------------------------");
            Dictionary<int,string> ogrenciler = new Dictionary<int, string>();
            SortedList<int,string> ogrenciler2 = new SortedList<int, string>();

            do
            {

                Console.WriteLine("Öğrenci ID:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Öğrenci Adı Soyadı :");
                kayit = Console.ReadLine();
                ogrenciler.Add(id, kayit);
                ogrenciler2.Add(id,kayit);
                Console.WriteLine("Kayıt'a devam edecekmisiniz.(E/H)");
                devam = Console.ReadLine();
            } 

            while (devam == "E" || devam == "e");



            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Normal Liste");
            Console.WriteLine("----------------------------------------");

            foreach (KeyValuePair<int,string> ogrenci in ogrenciler)
            {
                Console.WriteLine("Öğrenci ID :"+ogrenci.Key+"\t"+ogrenci.Value);
                
            }
            //sıralı liste
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Sıralı Liste");
            Console.WriteLine("----------------------------------------");
            foreach (KeyValuePair<int, string> ogrenci2 in ogrenciler2)
            {
                Console.WriteLine("Öğrenci ID :" + ogrenci2.Key + "\t" + ogrenci2.Value);

            }

            
        }
    }

  
}
