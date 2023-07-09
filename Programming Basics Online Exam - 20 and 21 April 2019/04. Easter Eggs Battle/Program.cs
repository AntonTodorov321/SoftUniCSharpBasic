using System;

namespace _04._Easter_Eggs_Battle
{
	class Program
	{
		static void Main(string[] args)
		{
			int eggFistPlayer = int.Parse(Console.ReadLine());
			int eggSecondPlayer = int.Parse(Console.ReadLine());
			bool isFirstPlayerLoose = false;
			bool isSecondPlayerLoose = false;

			string command;
			while ((command=Console.ReadLine())!="End")
			{
				if (command=="one")
				{
					eggSecondPlayer--;
				}
				else
				{
					eggFistPlayer--;
				}
				if (eggFistPlayer<1)
				{
					Console.WriteLine($"Player one is out of eggs. Player two has {eggSecondPlayer} eggs left.");
					isFirstPlayerLoose = true;
					break;
				}
				if (eggSecondPlayer<1)
				{
					Console.WriteLine($"Player two is out of eggs. Player one has {eggFistPlayer} eggs left.");
					isSecondPlayerLoose = true;
					break;
				}
			}
			if (!isFirstPlayerLoose&&!isSecondPlayerLoose)
			{
				Console.WriteLine($"Player one has {eggFistPlayer} eggs left.");
				Console.WriteLine($"Player two has {eggSecondPlayer} eggs left.");
			}
		}
	}
}
