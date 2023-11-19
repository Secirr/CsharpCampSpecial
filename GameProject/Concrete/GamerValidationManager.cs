using System;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class GamerValidationManager : IGamerValidationService
    {
        public bool GamerValidation(Gamer gamer)
        {
            return true;
        }
    }
}

