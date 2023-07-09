using System;

namespace _02._Godzilla_vs._Kong
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			int countStatist = int.Parse(Console.ReadLine());
			double outfitPrice =double.Parse(Console.ReadLine());
			double decorPrice = bujet * 0.1;
			if (countStatist>150)
			{
				outfitPrice -= outfitPrice * 0.1;
			}
			double totoalSum =decorPrice + (countStatist * outfitPrice);
			if (bujet>=totoalSum)
			{
				Console.WriteLine("Action!");
				Console.WriteLine($"Wingard starts filming with {bujet-totoalSum:f2} leva left.");
			}
			else
			{
				Console.WriteLine("Not enough money!");
				Console.WriteLine($"Wingard needs {totoalSum-bujet:f2} leva more.");

			}
		}
	}
}
