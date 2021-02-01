using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        private List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{Id = 1,BrandName = "Renault"},
                new Brand{Id = 2,BrandName = "Wolkswagen"},
                new Brand{Id = 3,BrandName = "Mercedes"},
                new Brand{Id = 4,BrandName = "BMV"},
            };
        }
        public List<Brand> GetAll()
        {
            return _brands;
        }

        public void GetById(Brand brand)
        {
            _brands.SingleOrDefault(p => p.Id == brand.Id);
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Update(Brand brand)
        {
            Brand brandUpdate = _brands.SingleOrDefault(p => p.Id == brand.Id);
            brandUpdate.BrandName = brand.BrandName;
        }

        public void Delete(Brand brand)
        {
            _brands.Remove(_brands.SingleOrDefault(p => p.Id == brand.Id));
        }
    }
}
