using System;

namespace _04._Trekking_Mania
{
	class Program
	{
		static void Main(string[] args)
		{
			int totolFood = int.Parse(Console.ReadLine());
			string command;
			bool isEnought = true;
			totolFood *= 1000;
			while ((command=Console.ReadLine())!= "Adopted")
			{
				int eatenFood = int.Parse(command);
				totolFood -= eatenFood;
			}
			if (totolFood < 0)
			{
				totolFood = Math.Abs(totolFood);
				Console.WriteLine($"Food is not enough. You need {totolFood} grams more.");
				isEnought = false;
			}
			if (isEnought)
			{
				Console.WriteLine($"Food is enough! Leftovers: {totolFood} grams.");
			}
		}
	}
}
