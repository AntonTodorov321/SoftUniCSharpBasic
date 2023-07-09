using System;

namespace _01._Easter_Bakery
{
	class Program
	{
		static void Main(string[] args)
		{
			double flourPrice = double.Parse(Console.ReadLine());
			double flourKg = double.Parse(Console.ReadLine());
			double suugarKg = double.Parse(Console.ReadLine());
			int eggsBarkCount = int.Parse(Console.ReadLine());
			int mayCount = int.Parse(Console.ReadLine());
			double sugarPrice = flourPrice - (flourPrice * 0.25);
			double eggBarkPrice = flourPrice + (flourPrice * 0.1);
			double mayPrice = sugarPrice - (sugarPrice * 0.8);
			double totoalSum = (flourKg * flourPrice) + (suugarKg * sugarPrice) + (eggBarkPrice * eggsBarkCount) + (mayCount * mayPrice);
			Console.WriteLine($"{totoalSum:f2}");


		}
	}
}
