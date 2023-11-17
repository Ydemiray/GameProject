using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        UserValidationManager userValidationManager;
        public GamerManager(UserValidationManager userValidationManager)
        {

            this.userValidationManager = userValidationManager;

        }

        public void Add(Gamer gamer)
        {
            userValidationManager.Validate(gamer);

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : "+ gamer.FirstName);
        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncelledi : "+ gamer.FirstName);
        }
    }
}
