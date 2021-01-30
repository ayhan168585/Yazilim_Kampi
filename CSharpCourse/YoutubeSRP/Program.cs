using System;

namespace YoutubeSRP
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class CustomerManager
    {
        public void TransactionalOperation()
        {
           
            Update();
            Insert();
        }

        private void Insert()
        {
            MyContext context = new MyContext();
            context.Insert();
        }

        private void Update()
        {
            MyContext context = new MyContext();
            context.Update();
        }
    }

    internal class MyContext
    {
        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }
    }
}
