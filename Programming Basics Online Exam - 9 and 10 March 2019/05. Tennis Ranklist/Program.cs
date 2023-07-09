using System;

namespace _05._Tennis_Ranklist
{
	class Program
	{
		static void Main(string[] args)
		{
			int countTournir = int.Parse(Console.ReadLine());
			int startPoint = int.Parse(Console.ReadLine());
			int counterWinTournir = 0;
			double totoalPoints = 0;
			for (int i = 0; i < countTournir; i++)
			{
				string placeTournir = Console.ReadLine();
				if (placeTournir == "W")
				{
					totoalPoints += 2000;
					counterWinTournir++;
				}
				else if (placeTournir == "F")
				{
					totoalPoints += 1200;
				}
				else
				{
					totoalPoints += 720;
				}
			}
			Console.WriteLine($"Final points: {totoalPoints+startPoint}");
			double avaragePoints = Math.Floor((double)totoalPoints/countTournir);
			Console.WriteLine($"Average points: {avaragePoints}");
			Console.WriteLine($"{(double)counterWinTournir/countTournir*100:f2}%");
		}
	}
}
