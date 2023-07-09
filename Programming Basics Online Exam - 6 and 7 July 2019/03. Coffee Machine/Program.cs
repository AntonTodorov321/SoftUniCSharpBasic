using System;

namespace _03._Coffee_Machine
{
	class Program
	{
		static void Main(string[] args)
		{
			string drink = Console.ReadLine();
			string sugar = Console.ReadLine();
			int countDrink = int.Parse(Console.ReadLine());
			double priceForDrink = 0;
			if (drink == "Espresso")
			{
				if (sugar == "Without")
				{
					priceForDrink = 0.9;
				}
				else if (sugar == "Normal")
				{
					priceForDrink = 1;
				}
				else
				{
					priceForDrink = 1.2;
				}
			}
			else if (drink == "Cappuccino")
			{
				if (sugar == "Without")
				{
					priceForDrink = 1;
				}
				else if (sugar == "Normal")
				{
					priceForDrink = 1.2;
				}
				else
				{
					priceForDrink = 1.6;
				}
			}
			else if (drink == "Tea")
			{
				if (sugar == "Without")
				{
					priceForDrink = 0.5;
				}
				else if (sugar == "Normal")
				{
					priceForDrink = 0.6;
				}
				else
				{
					priceForDrink = 0.7;
				}
			}
			double totoalSum = priceForDrink * countDrink;
			if (sugar== "Without")
			{
				totoalSum *= 0.65;
			}
			if (drink== "Espresso" && countDrink>=5)
			{
				totoalSum *= 0.75;
			}
			if (totoalSum>15)
			{
				totoalSum *= 0.8;
			}
			Console.WriteLine($"You bought {countDrink} cups of {drink} for {totoalSum:f2} lv.");
		}
	}
}
