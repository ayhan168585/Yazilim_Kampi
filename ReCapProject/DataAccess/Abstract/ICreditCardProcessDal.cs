using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICreditCardProcessDal:IEntityRepository<CreditCardProcess>
    {
        List<CreditCardProcessDto> GetCreditCardProcessDetails(Expression<Func<CreditCardProcess, bool>> filter = null);
    }
}
