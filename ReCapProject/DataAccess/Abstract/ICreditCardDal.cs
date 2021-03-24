using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICreditCardDal:IEntityRepository<CreditCard>
    {
        List<BankCreditCardDto> GetCardDetails(Expression<Func<CreditCard, bool>> filter = null);
    }
}
