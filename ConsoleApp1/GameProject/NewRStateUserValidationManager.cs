using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewRStateUserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1969 && gamer.FirstName=="AYHAN" && gamer.LastName=="ÖZER" && gamer.IdentityNumber==11999591936)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
