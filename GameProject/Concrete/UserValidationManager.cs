using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public void Validate(Gamer gamer)
        {
            
            if ( gamer.NationalityId=="56345436546" && gamer.FirstName=="Yusuf" && gamer.LastName=="Demiray"&&gamer.BirthOfYear==new DateTime(2002,11,1) ) 
            {
                Console.WriteLine("Kullanıcı Eklendi : "+gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Kullanıcı Bilgileri Uyuşmuyor!");
            }
            


        }

    }
}
