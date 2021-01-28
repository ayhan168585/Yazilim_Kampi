using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Entities;

namespace OzerGame.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
    }
}
