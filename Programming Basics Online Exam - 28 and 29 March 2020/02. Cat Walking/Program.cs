using System;

namespace _02._Cat_Walking
{
	class Program
	{
		static void Main(string[] args)
		{
			int minWalking = int.Parse(Console.ReadLine());
			int walkingPerDay = int.Parse(Console.ReadLine());
			int kaloriesForCat = int.Parse(Console.ReadLine());
			int totoalWalking = minWalking * walkingPerDay;
			double burenedFat = totoalWalking * 5.0;
			double neededBurnFat = kaloriesForCat * 0.5;
			if (burenedFat>neededBurnFat)
			{
				Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burenedFat}.");
			}
			else
			{
				Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burenedFat}.");
			}

		}
	}
}
