using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<List<BankCreditCardDto>> GetCardDetails();
        IDataResult<BankCreditCardDto> GetCardDetailsById(int cardId);
        IDataResult<CreditCard> GetById(int id);
        IDataResult<List<BankCreditCardDto>> GetCardsByBankId(int id);
        IResult Add(CreditCard card);
        IResult Update(CreditCard card);
        IResult Delete(CreditCard card);
    }
}
