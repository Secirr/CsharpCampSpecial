using System;
using GameProject.Entitites;

namespace GameProject.Abstract
{
	public interface IOrderService
	{
		void CampaignOrder(Campaign campaign);

		void Order(Gamer gamer);
	}
}

