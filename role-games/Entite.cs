using System;
namespace role_games
{

	//la classe principale
	public abstract class Entite



	{

		protected string name;
		protected bool isDead = false;
		protected int devicePoints;
		protected int damageMin;
		protected int damageMax;
		protected Random random = new Random();

		public Entite(string name)

		{
			this.name = name;


		}

		public void Attack(Entite entity)

		{
			int dammage = random.Next(damageMin, damageMax);

			entity.LoseDevicePoints(dammage);

			Console.WriteLine(this.name + "(" + this.devicePoints + ")" + " attack : " + entity.name);
			Console.WriteLine(entity.name + " lost" + dammage + " device points");
			Console.WriteLine("He's staying " + entity.devicePoints + " device points at " + entity.name);

			if (entity.isDead)
			{
				Console.WriteLine(entity.name + " is dead !!!!!");
			}



        }


        public void LoseDevicePoints(int devicePoints)

        {

			this.devicePoints -= devicePoints;

			if (this.devicePoints <=0 )
			{
				this.devicePoints = 0;

			     isDead = true;
			}

        }

		public bool IsDead()


		{
			return this.isDead;
		}

    }


}

