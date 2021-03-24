using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBankService
    {
        IDataResult<List<Bank>> GetAll();
        IDataResult<Bank> GetById(int id);
        IResult Add(Bank bank);
        IResult Update(Bank bank);
        IResult Delete(Bank bank);
    }
}
