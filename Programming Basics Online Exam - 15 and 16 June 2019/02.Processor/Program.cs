using System;

namespace _02.Processor
{
	class Program
	{
		static void Main(string[] args)
		{
				int targetProcessor = int.Parse(Console.ReadLine());
				int employeesCount = int.Parse(Console.ReadLine());
				int workingDaysCount = int.Parse(Console.ReadLine());
			double totoalHours = employeesCount * 8 * workingDaysCount;
			double precessorMade = Math.Floor(totoalHours / 3.0);
			if (precessorMade>targetProcessor)
			{
				Console.WriteLine($"Profit: -> {(precessorMade-targetProcessor)*110.1:f2} BGN");
			}
			else
			{
				Console.WriteLine($"Losses: -> {(targetProcessor-precessorMade)*110.1:f2} BGN");
			}
		}
	}
}
