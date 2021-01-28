using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   
        public class MusteriManager
        {

            public void Ekle(Musteri musterim)
            {

                Musteri musteri = new Musteri();
                Console.WriteLine("Müşteri Ekleme Bölümündesiniz");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Müsteri ID :");
                musteri.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Müsteri Hesap No :");
                musteri.HesapNo = Console.ReadLine();
                Console.WriteLine("Müsteri Adi :");
                musteri.Adi = Console.ReadLine();
                Console.WriteLine("Müsteri Soyadi :");
                musteri.Soyadi = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.HesapNo);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("{0} {1} isimli müşteri kaydedildi.", musteri.Adi, musteri.Soyadi);


            }

            public void Listeleme(Musteri musterim)
            {
                Musteri musterim1 = new Musteri();
                Musteri musterim2 = new Musteri();
                Musteri musterim3 = new Musteri();
                Musteri[] musterilerim = new Musteri[] { musterim1, musterim2, musterim3 };
                musterim1.Id = 1;
                musterim1.HesapNo = 1.ToString();
                musterim1.Adi = "Ayhan";
                musterim1.Soyadi = "Özer";
                musterim2.Id = 2;
                musterim2.HesapNo = 2.ToString();
                musterim2.Adi = "Harun";
                musterim2.Soyadi = "Özer";
                musterim3.Id = 3;
                musterim3.HesapNo = 3.ToString();
                musterim3.Adi = "Aydın";
                musterim3.Soyadi = "Özer";


                Console.WriteLine("Müşteri Listeleme Bölümündesiniz.");
                Console.WriteLine("-------------------------------------");
                foreach (var musteri in musterilerim)
                {
                    Console.WriteLine("Müşteri ID :" + musteri.Id);
                    Console.WriteLine("Müşteri Hesap No :" + musteri.HesapNo);
                    Console.WriteLine("Müşteri Adı :" + musteri.Adi);
                    Console.WriteLine("Müşteri Soyadı :" + musteri.Soyadi);
                    Console.WriteLine("----------------------------------");
                }
            }

            public void Sil(Musteri musteri)
            {
                int id;
                Musteri musterim1 = new Musteri();
                Musteri musterim2 = new Musteri();
                Musteri musterim3 = new Musteri();
                musterim1.Id = 1;
                musterim1.HesapNo = 1.ToString();
                musterim1.Adi = "Ayhan";
                musterim1.Soyadi = "Özer";
                musterim2.Id = 2;
                musterim2.HesapNo = 2.ToString();
                musterim2.Adi = "Harun";
                musterim2.Soyadi = "Özer";
                musterim3.Id = 3;
                musterim3.HesapNo = 3.ToString();
                musterim3.Adi = "Aydın";
                musterim3.Soyadi = "Özer";
                Musteri[] musteriler = new Musteri[] { musterim1, musterim2, musterim3 };

                Console.WriteLine("Silmek istediğiniz kayıdın ID'sini giriniz.");
                id = Convert.ToInt32(Console.ReadLine());
                if (id == musterim1.Id)
                {
                    Console.WriteLine("Ayhan Özer Silindi.");
                }
                else if (id == musterim2.Id)
                {
                    Console.WriteLine("Harun Özer Silindi.");
                }
                else if (id == musterim3.Id)
                {
                    Console.WriteLine("Aydın Özer Silindi.");
                }
                else
                {
                    Console.WriteLine("Herhangi bir kayıt silinmedi.");
                }


            }
        }
    }

