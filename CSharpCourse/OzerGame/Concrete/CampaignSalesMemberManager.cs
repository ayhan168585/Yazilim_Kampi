using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Abstract;
using OzerGame.Entities;

namespace OzerGame.Concrete
{
    public class CampaignSalesMemberManager:BaseSaleManager
    {
        private IMemberCheckService _memberCheckService;

        public CampaignSalesMemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public override void Sale(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                Console.WriteLine("{0}" + " " + "{1}'e kampanyalı satış yapıldı.", member.FirstName, member.LastName);
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
                Console.WriteLine("{0}" + " " + "{1}'e yapılan kampanyalı satış güncellendi.", member.FirstName, member.LastName);
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
                Console.WriteLine("{0}" + " " + "{1}'e yapılan kampanyalı satış silindi.", member.FirstName, member.LastName);
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil.");
            }
        }
    }
}
