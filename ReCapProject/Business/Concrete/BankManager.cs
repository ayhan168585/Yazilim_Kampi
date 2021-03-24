using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BankManager:IBankService
    {
        private IBankDal _bankDal;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        public IDataResult<List<Bank>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Bank>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Bank>>(_bankDal.GetAll(),Messages.BanksListed);
        }

        public IDataResult<Bank> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Bank>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Bank>(_bankDal.Get(p=>p.Id==id),Messages.BankDetailListed);
        }
     
        //[ValidationAspect(typeof(BankValidator))]
        IResult IBankService.Add(Bank bank)
        {
           _bankDal.Add(bank);
           return new SuccessResult(Messages.BankAdded);
        }

        IResult IBankService.Update(Bank bank)
        {
            _bankDal.Update(bank);
            return new SuccessResult(Messages.BankUpdated);
        }

        IResult IBankService.Delete(Bank bank)
        {
           _bankDal.Delete(bank);
           return new SuccessResult(Messages.BankDeleted);
        }
    }
}
