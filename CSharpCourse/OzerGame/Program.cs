using System;
using OzerGame.Abstract;
using OzerGame.Adapters;
using OzerGame.Concrete;
using OzerGame.Entities;

namespace OzerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMemberManager baseMemberManager=new MemberManager(new MernisServiceAdapter());

            baseMemberManager.Add(new Member {DateOfBirth = new DateTime(1969,8,24),FirstName = "Ayhan",LastName = "Özer",NationalityId = "11999591936"});
            baseMemberManager.Update(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });
            baseMemberManager.Delete(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });
            BaseSaleManager baseSaleManager=new SalesMemberManager(new MernisServiceAdapter());
            baseSaleManager.Sale(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });
            baseSaleManager.SaleUpdate(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });
            baseSaleManager.SaleDelete(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });
            BaseSaleManager campaignSalesManager=new CampaignSalesMemberManager(new MernisServiceAdapter());
            campaignSalesManager.Sale(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });
            campaignSalesManager.SaleUpdate(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });
            campaignSalesManager.SaleDelete(new Member { DateOfBirth = new DateTime(1969, 8, 24), FirstName = "Ayhan", LastName = "Özer", NationalityId = "11999591936" });

        }
    }
}
