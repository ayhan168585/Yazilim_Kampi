using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConserns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class CarManager : ICarService
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

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarListed); 
        }

        public IDataResult<Car> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Car>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id),Messages.CarDetailListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id),Messages.CarListedByBrand);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id),Messages.CarListedByColor);
        }

        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal fiyat)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice <= fiyat),Messages.CarListedByDailyPrice);
        }

        public IResult Add(Car car)
        {
          
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            ValidationTool.Validate(new CarValidator(),car);

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
