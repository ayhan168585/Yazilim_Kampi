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
using Core.CrossCuttingConserns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        [CacheAspect]
        public IDataResult<List<RentDetailDto>> GetRentDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<RentDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RentDetailDto>>(_rentalDal.GetDetailRental(), Messages.RentalListed);
        }

        [CacheAspect]
        public IDataResult<Rental> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id), Messages.GetRentDetail);
        }

        //[SecuredOperation("admin")]
        [CacheRemoveAspect("IRentalService.Get")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IRentalService.Get")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {

            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IRentalService.Get")]
        [TransactionScopeAspect]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<RentDetailDto>> GetByCustomer(int customerId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult <List<RentDetailDto>> (Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RentDetailDto>>(_rentalDal.GetDetailRental(p=>p.CustomerId==customerId),Messages.RentalListedByCustomer);
        }
    }
}
