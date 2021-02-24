using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
