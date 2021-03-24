using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;
        private ICarService _carService;
        string imagePath = @"C:\Users\Ayhan Özer\Desktop\Yazilim_Kampi\Angular\ReCapProject\recapproject\src\assets\images\";
        string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };

        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;

        }
        [CacheAspect]
        public IDataResult<List<CarImage>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CarImage>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImageListed);
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CarImage>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarId == carId).ToList(), Messages.CarImageDetailListed);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("ICarImageService.Get")]
        [ValidationAspect(typeof(BrandValidator))]
        [TransactionScopeAspect]
        public IResult Add(CarImage carImage, IFormFile file)
        {
            carImage.ImagePath = imagePath + FileHelper.CreateFileName(file, 20);
            carImage.Date = DateTime.Now;
            IResult result = BusinessRules.Run(CheckIfCarImageLimitExceded(carImage), FileHelper.CheckIfFileType(file, imageExtensions), FileHelper.Add(carImage.ImagePath, file));
            if (result != null)
            {
                return result;
            }

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("ICarImageService.Get")]
        [ValidationAspect(typeof(BrandValidator))]
        [TransactionScopeAspect]
        public IResult Update(CarImage carImage, IFormFile file)
        {
            string updatePath = _carImageDal.Get(ci => ci.Id == carImage.Id).ImagePath;
            IResult result = BusinessRules.Run(CheckIfCarImageLimitExceded(carImage), FileHelper.CheckIfFileType(file, imageExtensions), FileHelper.Delete(updatePath), FileHelper.Add(carImage.ImagePath, file));
            if (result != null)
            {
                return result;
            }
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("ICarImageService.Get")]
        [TransactionScopeAspect]
        public IResult Delete(CarImage carImage)
        {
            string deletePath = _carImageDal.Get(ci => ci.Id == carImage.Id).ImagePath;
            IResult result = BusinessRules.Run(CheckIfCarImageExists(carImage.Id), FileHelper.Delete(deletePath));
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        private IResult CheckIfCarImageLimitExceded(CarImage carImage)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carImage.CarId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceded);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCarImageExists(int id)
        {
            var result = _carImageDal.GetAll(ci => ci.Id == id).Any();
            if (!result)
            {
                return new ErrorResult(Messages.CarImageInvalid);
            }
            return new SuccessResult();
        }
    }
}
