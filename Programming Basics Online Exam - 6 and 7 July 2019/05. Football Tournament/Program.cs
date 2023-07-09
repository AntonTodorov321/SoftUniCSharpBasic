using System;

namespace _05._Football_Tournament
{
	class Program
	{
		static void Main(string[] args)
		{
			string teamName = Console.ReadLine();
			int countMatch = int.Parse(Console.ReadLine());
			int looseGameCounter = 0;
			int winGameCounter = 0;
			int equalityGameCounter = 0;
			int totoalPoints = 0;
			for (int i = 0; i < countMatch; i++)
			{
				char resultFromMatch = char.Parse(Console.ReadLine());
				if (resultFromMatch=='W')
				{
					winGameCounter++;
					totoalPoints += 3;
				}
				else if(resultFromMatch == 'D')
				{
					equalityGameCounter++;
					totoalPoints++;
				}
				else
				{
					looseGameCounter++;
				}
			}
			if (countMatch==0)
			{
				Console.WriteLine($"{teamName} hasn't played any games during this season.");
				return;
			}
			Console.WriteLine($"{teamName} has won {totoalPoints} points during this season.");
			Console.WriteLine("Total stats:");
			Console.WriteLine($"## W: {winGameCounter}");
			Console.WriteLine($"## D: {equalityGameCounter}");
			Console.WriteLine($"## L: {looseGameCounter}");
			Console.WriteLine($"Win rate: {winGameCounter/(double)countMatch*100:f2}%");
		}
	}
}
