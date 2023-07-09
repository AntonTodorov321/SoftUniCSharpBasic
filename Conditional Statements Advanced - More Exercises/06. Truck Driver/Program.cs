using System;

namespace _06._Truck_Driver
{
	class Program
	{
		static void Main(string[] args)
		{
			string season = Console.ReadLine();
			double kilometers = double.Parse(Console.ReadLine());
			double totalSum = 0;
			//			                      Пролет / Есен   Лято           Зима
			//км на месец <= 5000             0.75 лв./ км    0.90 лв./ км   1.05 лв./ км
			//5000 < км на месец <= 10000     0.95 лв./ км    1.10 лв./ км   1.25 лв./ км
			//10000 < км на месец <= 20000    1.45 лв./ км – за който и да е сезон
			if (season == "Spring" || season == "Autumn")
			{
				if (kilometers <= 5000)
					totalSum = kilometers * 0.75;
				else if (kilometers <= 10000)
					totalSum = kilometers * 0.95;
				else
					totalSum = kilometers * 1.45;
			}
			else if (season == "Summer")
			{
				if (kilometers <= 5000)
					totalSum = kilometers * 0.9;
				else if (kilometers <= 10000)
					totalSum = kilometers * 1.1;
				else
					totalSum = kilometers * 1.45;
			}
			else
			{
				if (kilometers <= 5000)
					totalSum = kilometers * 1.05;
				else if (kilometers <= 10000)
					totalSum = kilometers * 1.25;
				else
					totalSum = kilometers * 1.45;
			}
			totalSum *= 4;
			totalSum *= 0.9;
			Console.WriteLine($"{totalSum:f2}");
		}
	}
}
