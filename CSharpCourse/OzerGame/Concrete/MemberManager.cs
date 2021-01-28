using System;
using OzerGame.Abstract;
using OzerGame.Entities;

namespace OzerGame.Concrete
{
    public class MemberManager:BaseMemberManager
    {
        private IMemberCheckService _memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public override void Add(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                base.Add(member);
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil");
            }
           
        }

        public override void Update(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                base.Update(member);
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil");
            }
        }

        public override void Delete(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                base.Delete(member);
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil");
            }
        }
    }
}
