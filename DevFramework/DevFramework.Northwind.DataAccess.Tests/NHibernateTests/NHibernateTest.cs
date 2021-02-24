using DevFramework.DataAccess.Concrete.EntityFramework;
using DevFramework.DataAccess.Concrete.NHibernate;
using DevFramework.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Northwind.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {

            NhProductDal productDal=new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList();
            Assert.AreEqual(78,result.Count);

        }
        [TestMethod]
        public void Get_all_with_parameters_returns_filtered_products()
        {

            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);

        }
    }
}
