using System;

namespace _03._Time___15_Minutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minets = int.Parse(Console.ReadLine());
			minets += 15;
			if (minets >60)
			{
				hours++;
				minets-=60;
			}
			if (hours>=24)
			{
				hours -= 24;
			}
			Console.WriteLine($"{hours}:{minets:d2}");
		}
	}
}
