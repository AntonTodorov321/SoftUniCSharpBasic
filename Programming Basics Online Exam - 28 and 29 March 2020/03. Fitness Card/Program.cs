using System;

namespace _03._Fitness_Card
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			char sex = char.Parse(Console.ReadLine());
			int age = int.Parse(Console.ReadLine());
			string sport = Console.ReadLine();
			double totoalSum = 0;
			switch (sex)
			{
				case 'm':
					switch (sport)
					{
						case "Gym":
							totoalSum = 42;
							break;
						case "Boxing":
							totoalSum = 41;
							break;
						case "Yoga":
							totoalSum = 45;
							break;
						case "Zumba":
							totoalSum = 34;
							break;
						case "Dances":
							totoalSum = 51;
							break;
						case "Pilates":
							totoalSum = 39;
							break;
					}
					break;
				case 'f':
					switch (sport)
					{
						case "Gym":
							totoalSum = 35;
							break;
						case "Boxing":
							totoalSum = 37;
							break;
						case "Yoga":
							totoalSum = 42;
							break;
						case "Zumba":
							totoalSum = 31;
							break;
						case "Dances":
							totoalSum = 53;
							break;
						case "Pilates":
							totoalSum = 37;
							break;
					}
					break;
			}
			if (age<=19)
			{
				totoalSum *= 0.8;
			}
			if (bujet>=totoalSum)
			{
				Console.WriteLine($"You purchased a 1 month pass for {sport}.");
			}
			else
			{
				Console.WriteLine($"You don't have enough money! You need ${totoalSum-bujet:f2} more.");
			}
		}
	}
}
