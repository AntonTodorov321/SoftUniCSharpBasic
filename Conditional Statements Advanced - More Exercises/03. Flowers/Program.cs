using System;

namespace _03._Flowers
{
	class Program
	{
		static void Main(string[] args)
		{
			//•	На първия ред е броят на закупените хризантеми – цяло число в интервала[0... 200]
			//•	На втория ред е броят на закупените рози – цяло число в интервала[0... 200]
			//•	На третия ред е броят на закупените лалета – цяло число в интервала[0... 200]
			//•	На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
			//•	На петия ред е посочено дали денят е празник – [Y – да / N - не]
			int chrysanthemumsCount = int.Parse(Console.ReadLine());
			int roseCount = int.Parse(Console.ReadLine());
			int tulipCount = int.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			char holyday = char.Parse(Console.ReadLine());
			double totalSum = 0;
			//Сезон           Хризантеми       Рози              Лалета
			//Пролет / Лято   2.00 лв./ бр.    4.10 лв./ бр.    2.50 лв./ бр.
			//  Есен / Зима   3.75 лв./ бр.    4.50 лв./ бр.    4.15 лв./ бр.
			if (season == "Summer" || season == "Spring")
			{
				totalSum = (chrysanthemumsCount * 2) + (roseCount * 4.1) + (tulipCount * 2.5);
			}
			else
			{
				totalSum = (chrysanthemumsCount * 3.75) + (roseCount * 4.5) + (tulipCount * 4.15);
			}
			if (holyday == 'Y')
			{
				totalSum += totalSum * 0.15;
			}
			//•	За закупени повече от 7 лалета през пролетта – 5 % от цената на целият букет.
			if (tulipCount>7 && season== "Spring")
			{
				totalSum *=0.95;
			}
			if (roseCount >= 10 && season == "Winter")
				totalSum *=0.9;
			if ((chrysanthemumsCount+roseCount+tulipCount)>20)
			{
				totalSum *= 0.8;
			}
			//•	За закупени 10 или повече рози през зимата – 10 % от цената на целият букет.
			//•	За закупени повече от 20 цветя общо през всички сезони – 20 % от цената на целият букет.
			Console.WriteLine($"{totalSum+2:f2}");
		}
	}
}
