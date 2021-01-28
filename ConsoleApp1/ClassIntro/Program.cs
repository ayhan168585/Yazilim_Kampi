using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.KursunEgitmeni = "Engin";
            kurs1.IzlenmeOrani = 86;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem";
            kurs2.IzlenmeOrani = 64;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.KursunEgitmeni = "Berkay";
            kurs3.IzlenmeOrani = 80;

            Kurs[] kurslar=new Kurs[] {kurs1,kurs2,kurs3};

            foreach (Kurs k in kurslar)
            {
                Console.WriteLine(k.KursAdi+ " : " +k.KursunEgitmeni+ " : "+k.IzlenmeOrani);
            }

            Console.WriteLine(kurs1.KursAdi+":"+kurs1.KursunEgitmeni);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
