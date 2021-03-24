using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class CreditCard:IEntity
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public int UserId { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal CreditCardDeposit { get; set; }
    }
}
