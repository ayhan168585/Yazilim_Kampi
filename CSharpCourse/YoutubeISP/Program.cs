using System;

namespace YoutubeISP
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IPayable
    {
        void Pay();

    }

    interface IWorkable
    {
        void Work();
    }

    interface IEatable
    {
        void Eat();
    }
    class CompanyWorker : IPayable, IWorkable, IEatable
    {
        public void Pay()
        {

        }

        public void Eat()
        {

        }

        public void Work()
        {

        }
    }

    class OutsourceWorker : IPayable, IWorkable
    {
        public void Pay()
        {

        }
        public void Work()
        {
        }
    }

    class Robot : IWorkable
    {
        public void Work()
        {
        }
    }


}
