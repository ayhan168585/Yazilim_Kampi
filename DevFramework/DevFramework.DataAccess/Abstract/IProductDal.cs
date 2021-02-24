using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
