using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCreditCardDal:EfEntityRepositoryBase<CreditCard,ReCapProjectContext>,ICreditCardDal
    {
        public List<BankCreditCardDto> GetCardDetails(Expression<Func<CreditCard, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from b in context.Banks
                    join c in context.CreditCards
                        on b.Id equals c.BankId
                        join u in context.Users
                            on c.UserId equals u.Id
                    select new BankCreditCardDto()
                    {
                        Id = c.Id,
                        BankId = b.Id,
                        UserId = u.Id,
                        BankName = b.BankName,
                        CreditCardUserName = u.FirstName +" "+ u.LastName,
                        CreditCardNumber = c.CreditCardNumber,
                        CreditCardDeposit = c.CreditCardDeposit
                    };
                return result.ToList();
            }
        }
    }
}
