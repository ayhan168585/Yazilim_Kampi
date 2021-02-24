using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DevFramework.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(p => p.ProductId).Column("ProductID");
            Map(p => p.CategoryId).Column("CategoryID");
            Map(p => p.ProductName).Column("ProductName");
            Map(p => p.QuantityPerUnit).Column("QuantityPerUnit");
            Map(p => p.UnitPrice).Column("UnitPrice");
        }
    }
}
