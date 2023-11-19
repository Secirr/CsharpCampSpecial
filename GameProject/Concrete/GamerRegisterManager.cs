using System;
using Abstract.GameProject;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class GamerRegisterManager : IGamerRegisterService
    {
        IGamerValidationService _gamerValidationService;

        public GamerRegisterManager(IGamerValidationService gamerValidationService) 
        {
            _gamerValidationService = gamerValidationService;
        }


        public void Register(Gamer gamer)
        {
            if (_gamerValidationService.GamerValidation(gamer))
            {
                Console.WriteLine(gamer.FirstName + " has been confirmed and the registration process has taken place");
            }           
            else
            {
                Console.WriteLine(gamer.FirstName + " has not been confirmed and the registration process has not taken place");
            }
            
        }

        public void RegisterDelete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " registration has been deleted");
        }

        public void RegisterUpdate(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " information has been updated");
        }
    }
}

