using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar=new string[]{"Yazılım Geliştirici Kursu","Programlamaya Başlangıç için Temel Kurs","Java","Python","Web Programlama"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti.");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
           
        }
    }
}
