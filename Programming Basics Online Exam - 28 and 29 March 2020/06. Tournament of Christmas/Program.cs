using System;

namespace _06._Tournament_of_Christmas
{
	class Program
	{
		static void Main(string[] args)
		{
			int daysTournirCount = int.Parse(Console.ReadLine());
			string sport;
			double totoalMoney = 0;
			int winGamesCount = 0;
			int totoalWinGames = 0;
			int looseGamesCount = 0;
			int totoalLooseGames = 0;
			for (int i = 0; i < daysTournirCount; i++)
			{
				double moneyPerDay = 0;
				winGamesCount = 0;
				looseGamesCount = 0;
				while ((sport = Console.ReadLine())!= "Finish")
				{
					string result = Console.ReadLine();
					if (result=="win")
					{
						moneyPerDay += 20;
						winGamesCount++;
						totoalWinGames++;
					}
					else
					{
						looseGamesCount++;
						totoalLooseGames++;
					}
				}
				if (winGamesCount>looseGamesCount)
				{
					moneyPerDay += moneyPerDay * 0.1;
				}
				totoalMoney += moneyPerDay;

			}
			if (totoalWinGames>totoalLooseGames)
			{
				totoalMoney += totoalMoney * 0.2;
				Console.WriteLine($"You won the tournament! Total raised money: {totoalMoney:f2}");
			}
			else
			{
				Console.WriteLine($"You lost the tournament! Total raised money: {totoalMoney:f2}");
			}
		}
	}
}
