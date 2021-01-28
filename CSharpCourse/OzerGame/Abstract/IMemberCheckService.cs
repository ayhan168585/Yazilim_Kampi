using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Entities;

namespace OzerGame.Abstract
{
    public interface IMemberCheckService
    {
        bool CheckIfRealMember(Member member);
    }
}
