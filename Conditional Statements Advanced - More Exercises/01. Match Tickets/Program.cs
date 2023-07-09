using System;

namespace _01._Match_Tickets
{
	class Program
	{
		static void Main(string[] args)
		{
			//Входът се чете от конзолата и съдържа точно 3 реда:
			//•	На първия ред е бюджетът – реално число в интервала[1 000.00... 1 000 000.00]
			//•	На втория ред е категорията – "VIP" или "Normal"
			//•	На третия ред е броят на хората в групата – цяло число в интервала[1... 200]
			double bujet = double.Parse(Console.ReadLine());
			string category = Console.ReadLine();
			int groupPeople = int.Parse(Console.ReadLine());
			double totalSum = 0;
			double a = 0;
			if (category == "VIP")
			{
				totalSum =groupPeople* 499.99;
			}
			else
			{
				totalSum = groupPeople* 249.99;
			}
			//1 до 4 – 75 % от бюджета.
			//•	От 5 до 9 – 60 % от бюджета.
			//•	От 10 до 24 – 50 % от бюджета.
			//•	От 25 до 49 – 40 % от бюджета.
			//•	50 или повече – 25 % от бюджета.

			if (groupPeople <=4)
			{
				a =bujet*0.25;
			}
			else if (groupPeople<=9)
			{
				totalSum -= totalSum * 0.4;
			}
			else if (groupPeople <= 24)
			{
				totalSum -= totalSum * 0.5;
			}
			else if (groupPeople <= 49)
			{
				totalSum -= totalSum * 0.6;
			}
			else 
			{
				totalSum -= totalSum * 0.75;
			}
			if (bujet>=totalSum)
			{
				Console.WriteLine($"Yes! You have {bujet-totalSum:f2} leva left.");
			}
			else
			{
				Console.WriteLine($"Not enough money! You need {totalSum-bujet:f2} leva.");
			}
		}
	}
}
