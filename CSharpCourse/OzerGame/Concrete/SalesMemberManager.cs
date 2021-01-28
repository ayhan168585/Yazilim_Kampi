﻿using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Abstract;
using OzerGame.Entities;

namespace OzerGame.Concrete
{
    public class SalesMemberManager:BaseSaleManager
    {
        //Üye kontrolü üye işlemleri kısmında yapıldığından burada satış işlemleri sırasında ayrıca yapılmadı.
        public override void Sale(Member member)
        {
            
            base.Sale(member);
        }

        public override void SaleUpdate(Member member)
        {
            base.SaleUpdate(member);
        }

        public override void SaleDelete(Member member)
        {
            base.SaleDelete(member);
        }
    }
}
