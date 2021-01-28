using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager=new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer{Id=1,BirthYear=1969,FirstName="AYHAN",LastName="ÖZER",IdentityNumber=11999591936});
        }
    }
}
