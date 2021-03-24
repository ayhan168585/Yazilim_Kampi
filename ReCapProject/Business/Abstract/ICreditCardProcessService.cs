using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICreditCardProcessService
    {
        IDataResult<List<CreditCardProcess>> GetAll();
        IDataResult<List<CreditCardProcessDto>> GetCardProcessDetails();
        IDataResult<CreditCardProcessDto> GetCardProcessDetailsByCardId(int cardId);
        IDataResult<CreditCardProcessDto> GetCardProcessDetailsByProcessId(int processId);
        IDataResult<CreditCardProcess> GetById(int id);
        IDataResult<CreditCardProcessDto> GetCardProcessByBankId(int id);
        IResult Add(CreditCardProcess process);
        IResult Update(CreditCardProcess process);
        IResult Delete(CreditCardProcess process);
    }
}
