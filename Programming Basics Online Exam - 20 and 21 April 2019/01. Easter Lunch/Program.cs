using System;

namespace _01._Easter_Lunch
{
	class Program
	{
		static void Main(string[] args)
		{
			int easterBreadCount = int.Parse(Console.ReadLine());
			int eggsCount = int.Parse(Console.ReadLine());
			int cookesCount = int.Parse(Console.ReadLine());
			int egg = eggsCount * 12;
			double totoalSum = easterBreadCount * 3.2 + eggsCount * 4.35 + egg * 0.15 + cookesCount * 5.4;
			Console.WriteLine($"{totoalSum:f2}");

		}
	}
}
