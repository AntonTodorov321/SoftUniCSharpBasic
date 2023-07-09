using System;

namespace _05._Easter_Eggs
{
	class Program
	{
		static void Main(string[] args)
		{
			int countEgg = int.Parse(Console.ReadLine());
			int redEggCounter = 0;
			int orangeEggCounter = 0;
			int blueEggCounter = 0;
			int greenEggCounter = 0;
			int maxEgg = 0;
			string maxColor = "red";
			for (int counterEgg = 0; counterEgg < countEgg; counterEgg++)
			{
				string colorEgg = Console.ReadLine();
				if (colorEgg == "red")
				{
					redEggCounter++;
				}
				else if (colorEgg == "orange")
				{
					orangeEggCounter++;
				}
				else if (colorEgg == "blue")
				{
					blueEggCounter++;
				}
				else if (colorEgg == "green")
				{
					greenEggCounter++;
				}
			}
			maxEgg = redEggCounter;
			if (maxEgg < orangeEggCounter)
			{
				maxEgg = orangeEggCounter;
				maxColor = "orange";
			}
			if (maxEgg < blueEggCounter)
			{
				maxEgg = blueEggCounter;
				maxColor = "blue";
			}
			if (maxEgg < greenEggCounter)
			{
				maxEgg = greenEggCounter;
				maxColor = "green";
			}

			Console.WriteLine($"Red eggs: {redEggCounter}");
			Console.WriteLine($"Orange eggs: {orangeEggCounter}");
			Console.WriteLine($"Blue eggs: {blueEggCounter}");
			Console.WriteLine($"Green eggs: {greenEggCounter}");
			Console.WriteLine($"Max eggs: {maxEgg} -> {maxColor}");
		}
	}
}
