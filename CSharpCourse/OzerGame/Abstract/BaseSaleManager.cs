using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Entities;

namespace OzerGame.Abstract
{
    public abstract class BaseSaleManager:ISalesService
    {
        public virtual void Sale(Member member)
        {
            Console.WriteLine("{0}"+" "+"{1}'e satış yapıldı.",member.FirstName,member.LastName);
        }

        public virtual void SaleUpdate(Member member)
        {
            Console.WriteLine("{0}" + " " + "{1}'e yapılan satış güncellendi.", member.FirstName, member.LastName);
        }

        public virtual void SaleDelete(Member member)
        {
            Console.WriteLine("{0}" + " " + "{1}'e yapılan satış silindi.", member.FirstName, member.LastName);
        }
    }
}
