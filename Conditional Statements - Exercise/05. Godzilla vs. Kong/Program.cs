using System;

namespace _05._Godzilla_vs._Kong
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int statist = int.Parse(Console.ReadLine());
			double pricePerCloaths = double.Parse(Console.ReadLine());
			if (statist>150)
			{
				pricePerCloaths = pricePerCloaths - (pricePerCloaths * 0.1);
			}
			double decor = budget * 0.1;
			double costsMoney = decor + (statist * pricePerCloaths);
			double moneyLeft = budget-costsMoney;
			double neededMoney = costsMoney-budget;
			if (costsMoney>budget)
			{
				Console.WriteLine("Not enough money!");
				Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
			}
			else
			{
				Console.WriteLine("Action!");
				Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
			}

		}
	}
}
