using System;
namespace role_games
{
	public abstract class Personnaly : Entite


	{

		private int level;
		private int experience;



		public Personnaly(string name) : base(name)


		{
			this.name = name;
			level = 1;
			experience = 0;

		}

		public void experienceWin(int experience)

		{
			this.experience += experience;
			while (this.experience >= requiredExperience())
			{
				level += 1;
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Yeah : You have reached the level : "+ level + "!!");

				devicePoints += 10;
				damageMin += 2;
				damageMax +=2;
			}

		}

		public double requiredExperience()

		{
            // on arrondit le nieau, une fonction mathématique utilsée pour accroite en level chez les pokemons
            return Math.Round(4 * (Math.Pow(level, 3) / 5));
		}

		public string Features()

		{// retur du nom du personnage
			return this.name + "\n" +
				"Device points : " + devicePoints + "\n" +
				"Level : " + level + "\n" +
				"Experience points : (" + experience + "/" + requiredExperience() + ")\n" +
				"Damage : [" + damageMin + ";" + damageMax + "]";

        }

    }
}

