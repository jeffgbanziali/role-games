using System;
namespace role_games
{
	public class Monster : Entite


	{
		public Monster(string name) : base (name)



		{

			this.name = name;
			this.devicePoints = 60;
			this.damageMin = 5;
			this.damageMax = 10;

		}
	}
}

