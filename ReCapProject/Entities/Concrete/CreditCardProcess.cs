using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class CreditCardProcess:IEntity
    {
        public int Id { get; set; }
        public int CreditCardId { get; set; }
        public string ProcessName { get; set; }
        public decimal ProcessPrice { get; set; }
        public string Description { get; set; }
    }
}
