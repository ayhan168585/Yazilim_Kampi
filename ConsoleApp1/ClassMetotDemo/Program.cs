using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            char devam;
            do
            {

                MusteriManager musteriManager = new MusteriManager();
                Musteri musteri = new Musteri();
                Console.WriteLine("Bankamıza Hoş Geldiniz. Yapılacak İşlemi Seçiniz.(Lütfen sayı giriniz.");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1 : Müşteri Ekleme İşlemi");
                Console.WriteLine("2 : Müşteri Listeleme İşlemi");
                Console.WriteLine("3 : Müşteri Silme İşlemi");
                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        musteriManager.Ekle(musteri);

                    }
                    else if (secim == 2)
                    {

                        musteriManager.Listeleme(musteri);
                    }
                    else if (secim == 3)
                    {
                        musteriManager.Sil(musteri);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Girdiğiniz geçerli bir sayı değil.");

                }

                Console.WriteLine("Devam Etmek İstiyormusunuz. E/H");
                devam = Convert.ToChar(Console.ReadLine());


            } while (devam == 'E' || devam == 'e');
        }

    }
}
