using System;
using GameProject.Abstract;
using GameProject.Entitites;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " has been deleted");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " information has been updated");
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campaign has been created");
        }
    }
}

