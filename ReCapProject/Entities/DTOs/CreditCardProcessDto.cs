using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class CreditCardProcessDto:IDto
    {
        public int Id { get; set; }
        public int CreditCardId { get; set; }
        public int BankId { get; set; }
        public string CreditCardUserName { get; set; }
        public string BankName { get; set; }
        public string ProcessName { get; set; }
        public decimal ProcessPrice { get; set; }
        public string Description { get; set; }
    }
}
