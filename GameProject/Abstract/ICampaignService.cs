using System;
using GameProject.Entitites;

namespace GameProject.Abstract
{
	public interface ICampaignService
	{
        void NewCampaign(Campaign campaign);

        void CampaignDelete(Campaign campaign);

        void CampaignUpdate(Campaign campaign);
    }
}

