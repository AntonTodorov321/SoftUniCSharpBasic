using System;

namespace _06._Easter_Competition
{
	class Program
	{
		static void Main(string[] args)
		{
			int easterBreadCount = int.Parse(Console.ReadLine());
			string command;
			string nameBaker;
			int totoalSum = 0;
			int bestScore = int.MinValue;
			string bestBaker="";
			for (int counter = 0; counter < easterBreadCount; counter++)
			{
				nameBaker = Console.ReadLine();
				while ((command=Console.ReadLine())!="Stop")
				{
					int grade = int.Parse(command);
					totoalSum += grade;
				}
				Console.WriteLine($"{nameBaker} has {totoalSum} points.");
				if (totoalSum>bestScore)
				{
					Console.WriteLine($"{nameBaker} is the new number 1!");
					bestScore = totoalSum;
					bestBaker = nameBaker;
				}
				totoalSum = 0;
			}
			Console.WriteLine($"{bestBaker} won competition with {bestScore} points!");
		}
	}
}
