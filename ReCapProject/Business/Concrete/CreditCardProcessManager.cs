using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CreditCardProcessManager:ICreditCardProcessService
    {
        private ICreditCardProcessDal _creditCardProcessDal;

        public CreditCardProcessManager(ICreditCardProcessDal creditCardProcessDal)
        {
            _creditCardProcessDal = creditCardProcessDal;
        }

        public IDataResult<List<CreditCardProcess>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CreditCardProcess>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CreditCardProcess>>(_creditCardProcessDal.GetAll(),Messages.CreditCardProcessesListed);
        }

        public IDataResult<List<CreditCardProcessDto>> GetCardProcessDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CreditCardProcessDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CreditCardProcessDto>>(_creditCardProcessDal.GetCreditCardProcessDetails(),Messages.CreditCardProcessesListed);
        }

        public IDataResult<CreditCardProcessDto> GetCardProcessDetailsByCardId(int cardId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<CreditCardProcessDto>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<CreditCardProcessDto>(_creditCardProcessDal.GetCreditCardProcessDetails(p=>p.CreditCardId==cardId).SingleOrDefault(),Messages.CreditCardProcessByCreditCardIdListed);
        }

        public IDataResult<CreditCardProcessDto> GetCardProcessDetailsByProcessId(int processId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<CreditCardProcessDto>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<CreditCardProcessDto>(_creditCardProcessDal.GetCreditCardProcessDetails(p=>p.Id==processId).SingleOrDefault(),Messages.CreditCardProcessByProcessIdListed);
        }

        public IDataResult<CreditCardProcess> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<CreditCardProcess>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<CreditCardProcess>(_creditCardProcessDal.Get(p=>p.Id==id),Messages.CreditCardProcessByProcessIdListed);
        }

        public IDataResult<CreditCardProcessDto> GetCardProcessByBankId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<CreditCardProcessDto>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<CreditCardProcessDto>(_creditCardProcessDal.GetCreditCardProcessDetails().Where(p=>p.BankId==id).SingleOrDefault(),Messages.CreditCardProcessDetailByBankListed);
        }

        public IResult Add(CreditCardProcess process)
        {
           _creditCardProcessDal.Add(process);
           return new SuccessResult(Messages.CreditCardProcessAdded);
        }

        public IResult Update(CreditCardProcess process)
        {
            _creditCardProcessDal.Update(process);
            return new SuccessResult(Messages.CreditCardProcessUpdated);
        }

        public IResult Delete(CreditCardProcess process)
        {
           _creditCardProcessDal.Delete(process);
           return new SuccessResult(Messages.CreditCardProcessDeleted);
        }
    }
}
