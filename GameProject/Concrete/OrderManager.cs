using System;
using GameProject.Abstract;
using GameProject.Entitites;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {

        public void CampaignOrder(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " was took with the campaign");
        }

        public void Order(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " order took place");
        }


    }
}

