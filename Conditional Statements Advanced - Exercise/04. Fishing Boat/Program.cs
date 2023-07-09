using System;

namespace _04._Fishing_Boat
{
	class Program
	{
		static void Main(string[] args)
		{
			//Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
			// Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
			int budjet = int.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			int fisherMan = int.Parse(Console.ReadLine());
			double rent = 0;
			if (season == "Spring")
				rent = 3000;
			else if (season == "Summer" || season == "Autumn")
				rent = 4200;
			else if (season == "Winter")
				rent = 2600;

			if (fisherMan<=6)
			{
				rent = rent - (rent*0.1);
			}

			else if (fisherMan <= 11)
			{
				rent = rent - (rent * 0.15);
			}
			else
				rent = rent - (rent * 0.25);
			if (fisherMan % 2==0 && season!= "Autumn")
			{
				rent = rent - (rent * 0.05);
			}
			//Изход
			//Да се отпечата на конзолата един ред:
			if (budjet >= rent)
			{
				Console.WriteLine($"Yes! You have {budjet - rent:f2} leva left.");
			}
			else
				Console.WriteLine($"Not enough money! You need {rent-budjet:f2} leva.");
			//•	Ако бюджетът е достатъчен:
			//"Yes! You have {останалите пари} leva left."
			//•	Ако бюджетът НЕ Е достатъчен:
			//			"Not enough money! You need {сумата, която не достига} leva."
			//Сумите трябва да са форматирани с точност до два знака след десетичната запетая

		}
	}
}
