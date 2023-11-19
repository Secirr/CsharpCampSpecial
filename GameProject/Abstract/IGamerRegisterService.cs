using System;
using GameProject;

namespace Abstract.GameProject
{
	public interface IGamerRegisterService
	{
		void Register(Gamer gamer);

		void RegisterDelete(Gamer gamer);

		void RegisterUpdate(Gamer gamer);
	}
}

