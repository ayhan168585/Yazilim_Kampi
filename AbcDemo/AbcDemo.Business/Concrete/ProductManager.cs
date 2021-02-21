using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbcDemo.Business.Abstract;
using AbcDemo.Entities.Concrete;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace AbcDemo.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        private ILogger _logger;
        private ICache _cache;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
          
        }

        [LogAspect]
        public List<Product> GetAll()
        {
          
            return _productDal.GetAll();
        }
    }
}
