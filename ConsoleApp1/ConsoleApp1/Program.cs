using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış botonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış botonu");
            }
            else
            {
                Console.WriteLine("Değişmedi botonu");
            }
            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
