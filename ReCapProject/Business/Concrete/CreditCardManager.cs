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
    public class CreditCardManager:ICreditCardService
    {
        private ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CreditCard>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(),Messages.CreditCardsListed);
        }

        public IDataResult<List<BankCreditCardDto>> GetCardDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<BankCreditCardDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<BankCreditCardDto>>(_creditCardDal.GetCardDetails(),Messages.CreditCardsListed);
        }

        public IDataResult<BankCreditCardDto> GetCardDetailsById(int cardId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<BankCreditCardDto>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<BankCreditCardDto>(_creditCardDal.GetCardDetails(p=>p.Id==cardId).SingleOrDefault(),Messages.CreditCardDetailListed);
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<CreditCard>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(p=>p.Id==id),Messages.CreditCardDetailListed);
        }

        public IDataResult<List<BankCreditCardDto>> GetCardsByBankId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<BankCreditCardDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<BankCreditCardDto>>(_creditCardDal.GetCardDetails(p=>p.BankId==id),Messages.CreditCardListedByBank);
        }

        public IResult Add(CreditCard card)
        {
          _creditCardDal.Add(card);
          return new SuccessResult(Messages.CreditCardAdded);
        }

        public IResult Update(CreditCard card)
        {
           _creditCardDal.Update(card);
           return new SuccessResult(Messages.CreditCardUpdated);
        }

        public IResult Delete(CreditCard card)
        {
            _creditCardDal.Delete(card);
            return new SuccessResult(Messages.CreditCardDeleted);
        }
    }
}
