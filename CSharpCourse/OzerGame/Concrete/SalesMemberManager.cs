using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Abstract;
using OzerGame.Entities;

namespace OzerGame.Concrete
{
    public class SalesMemberManager:BaseSaleManager
    {
        private IMemberCheckService _memberCheckService;

        public SalesMemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        
        public override void Sale(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                base.Sale(member);
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil.");
            }
           
        }

        public override void SaleUpdate(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                base.SaleUpdate(member);
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil.");
            }
        }

        public override void SaleDelete(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                base.SaleDelete(member);
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil.");
            }
        }
    }
}
