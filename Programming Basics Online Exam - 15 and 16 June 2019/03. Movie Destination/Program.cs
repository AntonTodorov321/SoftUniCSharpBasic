using System;

namespace _03._Movie_Destination
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.Бюджет на филма – реално число в диапазона[100 000.0… 2 000 000.0]
			//2.Дестинация – текст, с възможности "Dubai", "Sofia" и "London"
			//3.Сезон – текст, с възможности "Summer" и "Winter"
			//4.Брой дни  – цяло число в диапазона[1… 40]
			double bujet =double.Parse(Console.ReadLine());
			string destination = Console.ReadLine();
			string seazon = Console.ReadLine();
			int daysCount = int.Parse(Console.ReadLine());
			double priseForDay = 0;
			if (destination== "Dubai")
			{
				if (seazon== "Winter")
				{
					priseForDay = 45000;
				}
				else
				{
					priseForDay = 40000;
				}
			}
			if (destination== "Sofia")
			{
				if (seazon== "Winter")
				{
					priseForDay = 17000;
				}
				else
				{
					priseForDay = 12500;
				}
			}
			if (destination== "London")
			{
				if (seazon== "Winter")
				{
					priseForDay = 24000;
				}
				else
				{
					priseForDay = 20250;
				}
			}
			double totoalPrise = priseForDay * daysCount;
			if (destination== "Dubai")
			{
				totoalPrise *= 0.7;
			}
			if (destination== "Sofia")
			{
				totoalPrise += totoalPrise * 0.25;
			}
			if (bujet>totoalPrise)
			{
				Console.WriteLine($"The budget for the movie is enough! We have {bujet-totoalPrise:f2} leva left!");
			}
			else
			{
				Console.WriteLine($"The director needs {totoalPrise-bujet:f2} leva more!");
			}

		}
	}
}
