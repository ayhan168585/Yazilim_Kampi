using System;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem=new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            
            //Console.WriteLine(dortIslem.Topla(3, 4));
            var tip = typeof(DortIslem);
            //DortIslem dortIslem= (DortIslem)Activator.CreateInstance(tip,6,5);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());
            var instance = Activator.CreateInstance(tip, 6, 5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
                Console.WriteLine(methodInfo.Invoke(instance,null));
                Console.WriteLine("--------------------------------------------------------");
                var metotlar = tip.GetMethods();
                foreach (var info in metotlar)
                {
                    Console.WriteLine("Metot Adı : {0}",info.Name);
                    foreach (var parameterInfo in info.GetParameters())
                    {
                        Console.WriteLine("Parametre:{0}",parameterInfo);
                    }

                    foreach (var infoAttribute in info.GetCustomAttributes())
                    {
                        Console.WriteLine("Attribute Name: {0} ",infoAttribute.GetType().Name);
                    }
                }
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {
            
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MetodNameAttribute:Attribute
    {
        private string _name;

        public MetodNameAttribute(string name)
        {
            _name = name;
        }
    }
}
