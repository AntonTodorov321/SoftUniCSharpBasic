using System;

namespace _05._Oscars
{
	class Program
	{
		static void Main(string[] args)
		{
			string actorName = Console.ReadLine();
			double pointFromAcademi = double.Parse(Console.ReadLine());
			int countEvaluators = int.Parse(Console.ReadLine());
			double totoalPoints = pointFromAcademi;
			bool isEnought = false;
			for (int counterEvaluator = 0; counterEvaluator < countEvaluators; counterEvaluator++)
			{
				string nameEvaluator = Console.ReadLine();
				double pointsFromEvaluator=double.Parse(Console.ReadLine());
				int lenghtName = nameEvaluator.Length;
				totoalPoints += lenghtName * pointsFromEvaluator / 2;
				if (totoalPoints>1250.5)
				{
					Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totoalPoints:f1}!");
					isEnought = true;
					break;
				}
			}
			if (!isEnought)
			{
				Console.WriteLine($"Sorry, {actorName} you need {1250.5-totoalPoints:f1} more!");
			}
		}
	}
}
