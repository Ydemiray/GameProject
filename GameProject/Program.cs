using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Discount = 45;

            Campaign campaign2 = new Campaign {Id=2,Discount=35 };


            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Yusuf";
            gamer1.LastName = "Demiray";
            gamer1.BirthOfYear = new DateTime(2002,11,1);
            gamer1.NationalityId = "56345436546";

            Gamer gamer2 = new Gamer { Id=2,FirstName="Merve",LastName="Karatepe",NationalityId="4182483248923",
                BirthOfYear=new DateTime(2003,10,17)};


            Sale sale1 = new Sale { GameName = "League Of Legends", OrderNo = 1,Price=35 };

            Sale sale2 = new Sale();
            sale2.GameName = "Wolfteam";
            sale2.Price = 10;
            sale2.OrderNo = 2;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer2);
            gamerManager.Delete(gamer1);

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaign1);
            campaingManager.Update(campaign1);
            campaingManager.Delete(campaign2);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(sale1,gamer1,campaign2);



            
            








        }
    }
}