using System;

namespace _04._Easter_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			int avilableEgg = int.Parse(Console.ReadLine());
			string command;
			bool isFinished = false;
			int leftEgg = 0;
			int soldEgg = 0;
			while ((command=Console.ReadLine())!= "Close")
			{
				int howMuch = int.Parse(Console.ReadLine());
				if (command== "Buy")
				{
					leftEgg = avilableEgg;
					avilableEgg -= howMuch;
					soldEgg += howMuch;
				}
				else
				{
					avilableEgg += howMuch;
				}
				if (avilableEgg<=0)
				{
					Console.WriteLine("Not enough eggs in store!");
					Console.WriteLine($"You can buy only {leftEgg}.");
					isFinished = true;
					break;
				}
			}
			if (!isFinished)
			{
				Console.WriteLine("Store is closed!");
				Console.WriteLine($"{soldEgg} eggs sold.");
			}
		}
	}
}
