using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Sale sale, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Ürünü Satın Alan kişi : " + gamer.FirstName +" Oyun ismi : "+sale.GameName + " Oyun Fiyatı fiyatı : "+(sale.Price-(sale.Price*campaign.Discount)/100));
        }
    }
}
