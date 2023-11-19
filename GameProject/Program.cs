using Abstract.GameProject;
using GameProject;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entitites;

ICampaignService campaign = new CampaignManager();
IGamerValidationService gamerValidationManager = new GamerValidationManager();
IGamerRegisterService register = new GamerRegisterManager(gamerValidationManager);
IOrderService sale = new OrderManager();

Gamer gamer1 = new Gamer();
gamer1.Id = 1;
gamer1.FirstName = "kadir";
gamer1.LastName = "Özdemir";
gamer1.BirthYear = new DateTime(2000, 5, 12);
gamer1.IdentityNumber = "23456476546";

Campaign campaign1 = new Campaign();
campaign1.Id = 1;
campaign1.Name = "Black Friday";
campaign1.Desc = "Just Special Fridays Campaign";

register.Register(gamer1);
register.RegisterDelete(gamer1);
register.RegisterUpdate(gamer1);

campaign.NewCampaign(campaign1);
campaign.CampaignDelete(campaign1);
campaign.CampaignUpdate(campaign1);

sale.CampaignOrder(campaign1);
sale.Order(gamer1);

Console.ReadKey();
