using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime); 
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(),Messages.CarListed);
        }

        public IDataResult<Car> Get(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Car>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id),Messages.CarDetailListed);
        }

        public IResult Add(Car car)
        {
            var context = new ValidationContext<Car>(car);
            CarValidator carValidator=new CarValidator();
            var result = carValidator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
           _carDal.Add(car);
           return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
           _carDal.Update(car);
           return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
