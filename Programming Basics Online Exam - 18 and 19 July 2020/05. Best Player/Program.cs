using System;

namespace _05._Best_Player
{
	class Program
	{
		static void Main(string[] args)
		{
			string playersName;
			int maxGoal = int.MinValue;
			string bestPlayerName="";
			while ((playersName = Console.ReadLine()) != "END")
			{
				int counterGoal = int.Parse(Console.ReadLine());
				if (counterGoal > maxGoal)
				{
					maxGoal = counterGoal;
					bestPlayerName = playersName;
				}
				if (counterGoal>=10)
				{
					break;
				}
			}
			Console.WriteLine($"{bestPlayerName} is the best player!");
			if (maxGoal>=3)
			{
				Console.WriteLine($"He has scored {maxGoal} goals and made a hat-trick !!!");
			}
			else
			{
				Console.WriteLine($"He has scored {maxGoal} goals.");
			}
		}
	}
}
