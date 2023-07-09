using System;

namespace _03._Pastry_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			string cake = Console.ReadLine();
			int cakeOrder = int.Parse(Console.ReadLine());
			int daysOfMonth = int.Parse(Console.ReadLine());
			double totoalSum = 0;
			if (cake== "Cake")
			{
				if (daysOfMonth<=15)
				{
					totoalSum = 24 * cakeOrder;
				}
				else
				{
					totoalSum = 28.7 * cakeOrder;
				}
			}
			else if (cake== "Souffle")
			{
				if (daysOfMonth <= 15)
				{
					totoalSum = 6.66 * cakeOrder;
				}
				else
				{
					totoalSum = 9.8 * cakeOrder;
				}
			}
			else
			{
				if (daysOfMonth <= 15)
				{
					totoalSum = 12.6 * cakeOrder;
				}
				else
				{
					totoalSum = 16.98 * cakeOrder;
				}
			}
			if (daysOfMonth<=22)
			{
				if (totoalSum<200)
				{
					totoalSum *= 0.85;
				}
				else if (totoalSum>200)
				{
					totoalSum *= 0.75;
				}
			}
			if (daysOfMonth<=15)
			{
				totoalSum *= 0.9;
			}
			Console.WriteLine($"{totoalSum:f2}");

		}
	}
}
