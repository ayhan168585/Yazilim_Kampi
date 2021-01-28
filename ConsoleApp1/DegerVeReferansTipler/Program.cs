using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayi3=new int[]{10,20,30};
            int[] sayi4=new int[]{100,200,300};
            sayi3 = sayi4;
            sayi4[0] = 999;
            Console.WriteLine(sayi3[0]);
        }
    }
}
