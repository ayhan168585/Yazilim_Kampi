using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 230000,ModelYear = 2020,Description = "Yeni Model"},
                new Car{Id = 2,BrandId = 1,ColorId = 2,DailyPrice = 200000,ModelYear = 2019,Description = "Cabrio"},
                new Car{Id = 3,BrandId = 2,ColorId = 1,DailyPrice = 170000,ModelYear = 2016,Description = "Sedan"},
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(Car car)
        {
            _cars.SingleOrDefault(p => p.Id == car.Id);
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(p => p.Id == car.Id));
        }
    }
}
