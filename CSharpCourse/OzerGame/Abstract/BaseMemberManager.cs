using System;
using System.Collections.Generic;
using System.Text;
using OzerGame.Entities;

namespace OzerGame.Abstract
{
    public abstract class BaseMemberManager:IMemberService
    {
        public virtual void Add(Member member)
        {
            Console.WriteLine("Üye eklendi. :" + member.FirstName + " " + member.LastName);

        }

        public virtual void Update(Member member)
        {
            Console.WriteLine("Üye güncellendi. :" + member.FirstName + " " + member.LastName);
        }

        public virtual void Delete(Member member)
        {
            Console.WriteLine("Üye silindi. :" + member.FirstName + " " + member.LastName);
        }
    }
}
