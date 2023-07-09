using System;

namespace _03._Painting_Eggs
{
	class Program
	{
		static void Main(string[] args)
		{
			string sizeEgg = Console.ReadLine();
			string paintEgg = Console.ReadLine();
			int batchEgg = int.Parse(Console.ReadLine());
			double priceForBatch = 0;
			if (sizeEgg == "Large")
			{
				if (paintEgg == "Red")
				{
					priceForBatch = 16;
				}
				else if (paintEgg == "Green")
				{
					priceForBatch = 12;
				}
				else
				{
					priceForBatch = 9;
				}
			}
			if (sizeEgg == "Medium")
			{
				if (paintEgg == "Red")
				{
					priceForBatch = 13;
				}
				else if (paintEgg == "Green")
				{
					priceForBatch = 9;
				}
				else
				{
					priceForBatch = 7;
				}
			}
			if (sizeEgg == "Small")
			{
				if (paintEgg == "Red")
				{
					priceForBatch = 9;
				}
				else if (paintEgg == "Green")
				{
					priceForBatch = 8;
				}
				else
				{
					priceForBatch = 5;
				}
			}
			double totoalSum = priceForBatch * batchEgg;
			totoalSum *= 0.65;
			Console.WriteLine($"{totoalSum:f2} leva.");

		}
	}
}
