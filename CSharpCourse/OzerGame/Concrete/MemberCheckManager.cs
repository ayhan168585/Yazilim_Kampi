using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using OzerGame.Abstract;
using OzerGame.Entities;

namespace OzerGame.Concrete
{
    public class MemberCheckManager:IMemberCheckService
    {
        public bool CheckIfRealMember(Member member)
        {
            return true;
        }
    }
}
