using System;

namespace _05._PC_Game_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			int countGames = int.Parse(Console.ReadLine());
			int hearthstoneCounter = 0;
			int forniteCounter = 0;
			int overwatchCounter = 0;
			int anotherCounter = 0;
			for (int i = 0; i < countGames; i++)
			{
				string nameGame = Console.ReadLine();
				if (nameGame== "Hearthstone")
				{
					hearthstoneCounter++;
				}
				else if (nameGame == "Fornite")
				{
					forniteCounter++;
				}
				else if (nameGame == "Overwatch")
				{
					overwatchCounter++;
				}
				else
				{
					anotherCounter++;
				}
			}
			Console.WriteLine($"Hearthstone - {hearthstoneCounter/(double)countGames*100:f2}%");
			Console.WriteLine($"Fornite - {forniteCounter / (double)countGames * 100:f2}%");
			Console.WriteLine($"Overwatch - {overwatchCounter / (double)countGames * 100:f2}%");
			Console.WriteLine($"Others - {anotherCounter / (double)countGames * 100:f2}%");
		}
	}
}
