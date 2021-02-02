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
        private List<Brand> _brands;
        private List<Color> _colors;


        public InMemoryCarDal(List<Car> cars)
        {
            _cars = cars;
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
            var carUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
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
