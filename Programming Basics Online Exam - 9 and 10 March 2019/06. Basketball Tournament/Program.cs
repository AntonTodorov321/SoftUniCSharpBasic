using System;

namespace _06._Basketball_Tournament
{
	class Program
	{
		static void Main(string[] args)
		{
			string nameTournir;
			int winMatch = 0;
			int looseMatch = 0;
			int totoalMatch = 0;
			while ((nameTournir=Console.ReadLine())!= "End of tournaments")
			{
				int match = int.Parse(Console.ReadLine());
				for (int matchCounter = 1; matchCounter <= match; matchCounter++)
				{
					int desiTeamPoints= int.Parse(Console.ReadLine());
					int otherTeamPoints= int.Parse(Console.ReadLine());
					if (desiTeamPoints>otherTeamPoints)
					{
						winMatch++;
						Console.WriteLine($"Game {matchCounter} of tournament {nameTournir}: win with {desiTeamPoints-otherTeamPoints} points.");
					}
					else
					{
						looseMatch++;
						Console.WriteLine($"Game {matchCounter} of tournament {nameTournir}: lost with {otherTeamPoints-desiTeamPoints} points.");
					}
					totoalMatch++;
				}
			}
			Console.WriteLine($"{winMatch/(double)totoalMatch*100:f2}% matches win");
			Console.WriteLine($"{looseMatch/(double)totoalMatch*100:f2}% matches lost");
		}
	}
}
