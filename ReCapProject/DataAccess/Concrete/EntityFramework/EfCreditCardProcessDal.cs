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
    public class EfCreditCardProcessDal:EfEntityRepositoryBase<CreditCardProcess,ReCapProjectContext>,ICreditCardProcessDal
    {
        public List<CreditCardProcessDto> GetCreditCardProcessDetails(Expression<Func<CreditCardProcess, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in context.CreditCardProcesses
                    join cr in context.CreditCards
                        on c.CreditCardId equals cr.Id
                        join u in context.Users
                            on cr.UserId equals u.Id
                    join b in context.Banks
                        on cr.BankId equals b.Id
                    select new CreditCardProcessDto()
                    {
                        Id = c.Id,
                        CreditCardId = cr.Id,
                        CreditCardUserName = u.FirstName+" "+u.LastName,
                        BankId = b.Id,
                        BankName = b.BankName,
                        ProcessName = c.ProcessName,
                        ProcessPrice = c.ProcessPrice,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }
    }
}
