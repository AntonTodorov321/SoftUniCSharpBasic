using System;

namespace _09._Ski_Trip
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int dayRest = int.Parse(Console.ReadLine());
			string plaseForRest = Console.ReadLine();
			string evaluation = Console.ReadLine();
			double sum = 0;
			if (plaseForRest == "room for one person")
			{
				dayRest -= 1;
				sum = dayRest * 18;
			}
			else if (plaseForRest == "apartment")
			{
				dayRest -= 1;
				sum = dayRest * 25;
			}
			else
			{
				dayRest -= 1;
				sum = dayRest * 35;
			}

			if (plaseForRest== "apartment")
			{
				if (dayRest<10)
				{
					sum *= 0.7;
				}
				else if (dayRest > 15)
				{
					sum *= 0.5;
				}
				else
				{
					sum *= 0.65;
				}
			}
			else if (plaseForRest == "president apartment")
			{
				if (dayRest < 10)
				{
					sum *= 0.9;
				}
				else if (dayRest > 15)
				{
					sum *= 0.8;
				}
				else
				{
					sum *= 0.85;
				}
			}
			//След престоя, оценката на Атанас за услугите на хотела може да е позитивна(positive) или негативна(negative).Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25 % от нея.Ако оценката му е негативна приспада от цената 10 %.
			if (evaluation == "positive")
			{
				sum += (sum * 0.25);
			}
			else
				sum *= 0.9;
			Console.WriteLine($"{sum:f2}");
		}
		//Изход
		//На конзолата трябва да се отпечата един ред:
		//•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.


	}
}	
