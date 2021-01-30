using System;

namespace YoutubeOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerService customerManager=new CustomerManager(new NhCustomerDal());
            customerManager.Add();
        }
    }

    class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add()
        {
           _customerDal.Add();
        }
    }

    internal interface ICustomerService
    {
        void Add();
    }

    class EfCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added By EF");
        }
    }
    class NhCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added By NH");
        }
    }

    internal interface ICustomerDal
    {
        void Add();
    }
}
