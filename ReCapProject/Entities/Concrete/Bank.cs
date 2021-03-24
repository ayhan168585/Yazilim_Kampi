using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters;
using Core.Entities;

namespace Entities.Concrete
{
    public class Bank:IEntity
    {
        public int Id { get; set; }
        public string BankName { get; set; }
    }
}
