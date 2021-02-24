using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }

    }
}
