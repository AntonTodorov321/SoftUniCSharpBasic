using System;

namespace _05._Easter_Bake
{
	class Program
	{
		static void Main(string[] args)
		{
			int easterBreadCount = int.Parse(Console.ReadLine());
			double sugarTotal = 0;
			double flourTotal = 0;
			int maxSugar = int.MinValue;
			int maxFlour = int.MinValue;
			for (int counter = 0; counter < easterBreadCount; counter++)
			{
				int sugarGram= int.Parse(Console.ReadLine());
				int flourGram= int.Parse(Console.ReadLine());
				sugarTotal += sugarGram;
				flourTotal += flourGram;
				if (sugarGram>maxSugar)
				{
					maxSugar = sugarGram;
				}
				if (flourGram>maxFlour)
				{
					maxFlour = flourGram;
				}
			}
			sugarTotal /= 950;
			flourTotal /= 750;
			sugarTotal = Math.Ceiling(sugarTotal);
			flourTotal = Math.Ceiling(flourTotal);
			Console.WriteLine($"Sugar: {sugarTotal}");
			Console.WriteLine($"Flour: {flourTotal}");
			Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");

		}
	}
}
