﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
               return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<RentalDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail(),Messages.RentalListed);
        }

        public IDataResult<Rental> Get(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(p=>p.Id==id),Messages.GetRentDetail);
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Update(Rental rental)
        {
           _rentalDal.Update(rental);
           return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult Delete(Rental rental)
        {
           _rentalDal.Delete(rental);
           return new SuccessResult(Messages.RentalDeleted);
        }
    }
}
