
using System;

namespace _04._Toy_Shop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double priceExcursion = double.Parse(Console.ReadLine());
			int puzzeCount = int.Parse(Console.ReadLine());
			int dollsCount = int.Parse(Console.ReadLine());
			int plushiBearsCount = int.Parse(Console.ReadLine());
			int minionsCount = int.Parse(Console.ReadLine());
			int trucksCount = int.Parse(Console.ReadLine());

			double moneyToys = (puzzeCount * 2.6) + (dollsCount * 3) + (plushiBearsCount * 4.1) + (minionsCount * 8.2) + (trucksCount * 2);
			int toysCount = puzzeCount + dollsCount + plushiBearsCount + minionsCount + trucksCount;
			if (toysCount>=50)
			{
				moneyToys = moneyToys - (moneyToys * 0.25);
			}
			moneyToys = moneyToys - (moneyToys * 0.1);

			if (priceExcursion<=moneyToys)
			{
				double moneyLeft = moneyToys - priceExcursion;
				Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
			}
			else
			{
				double moneyNeeded = priceExcursion - moneyToys;
				Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
			}

		}
	}
}
