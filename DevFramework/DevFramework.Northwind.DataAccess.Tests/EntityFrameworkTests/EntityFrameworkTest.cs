using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevFramework.DataAccess.Concrete.EntityFramework;

namespace DevFramework.Northwind.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {

            EfProductDal productDal=new EfProductDal();
            var result = productDal.GetList();
            Assert.AreEqual(78,result.Count);

        }
        [TestMethod]
        public void Get_all_with_parameters_returns_filtered_products()
        {

            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);

        }
    }
}
