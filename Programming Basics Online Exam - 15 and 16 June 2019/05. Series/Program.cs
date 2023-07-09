using System;

namespace _05._Series
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			int countMoves = int.Parse(Console.ReadLine());
			bool noMoreMoney = false;
			for (int counterMoves = 0; counterMoves < countMoves; counterMoves++)
			{
				string nameMove = Console.ReadLine();
				double priseForMoves = double.Parse(Console.ReadLine());
				if (nameMove == "Thrones")
				{
					bujet -= priseForMoves - (priseForMoves * 0.5);
				}
				else if (nameMove == "Lucifer")
				{
					bujet -= priseForMoves - (priseForMoves * 0.4);
				}
				else if (nameMove == "Protector")
				{
					bujet -= priseForMoves - (priseForMoves * 0.3);
				}
				else if (nameMove == "TotalDrama")
				{
					bujet -= priseForMoves - (priseForMoves * 0.2);
				}
				else if (nameMove == "Area")
				{
					bujet -= priseForMoves-( priseForMoves* 0.1);
				}
				else
				{
					bujet -= priseForMoves;
				}
				if (bujet<0)
				{
					bujet = Math.Abs(bujet);
					Console.WriteLine($"You need {bujet:f2} lv. more to buy the series!");
					noMoreMoney = true;
					break;
				}
			}
			if (!noMoreMoney)
			{
				Console.WriteLine($"You bought all the series and left with {bujet:f2} lv.");
			}
		}
	}
}
