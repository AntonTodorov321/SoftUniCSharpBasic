using System;

namespace Shopping
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double bugdet = double.Parse(Console.ReadLine());
			int videoCardCount = int.Parse(Console.ReadLine());
			int processorCount = int.Parse(Console.ReadLine());
			int ramMemoryCount = int.Parse(Console.ReadLine());
			double videoCardPrice = videoCardCount * 250;
			double oneProcessorPrice = videoCardPrice * 0.35;
			double processorPrice = processorCount * oneProcessorPrice;
			double oneRamMemory = videoCardPrice * 0.1;
			double ramMemoryPrice = ramMemoryCount * oneRamMemory;
			double totalSum = ramMemoryPrice + processorPrice + videoCardPrice;
			if (videoCardCount>processorCount)
			{
				totalSum = totalSum - (totalSum * 0.15);
			}
			double leftBuget = bugdet - totalSum;
			double moneyNeeded = totalSum - bugdet;
			if (bugdet>=totalSum)
			{
				Console.WriteLine($"You have {leftBuget:f2} leva left!");
			}
			else
			{
				Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
			}
		}
	}
}
