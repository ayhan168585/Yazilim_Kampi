using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void GetById(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
