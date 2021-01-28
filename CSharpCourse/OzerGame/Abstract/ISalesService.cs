using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Entities;

namespace OzerGame.Abstract
{
    public interface ISalesService
    {
        void Sale(Member member);
        void SaleUpdate(Member member);
        void SaleDelete(Member member);
    }
}
