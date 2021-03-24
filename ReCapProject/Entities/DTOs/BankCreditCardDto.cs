using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class BankCreditCardDto:IDto
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public int UserId { get; set; }
        public string BankName { get; set; }
        public string CreditCardUserName { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal CreditCardDeposit { get; set; }
    }
}
