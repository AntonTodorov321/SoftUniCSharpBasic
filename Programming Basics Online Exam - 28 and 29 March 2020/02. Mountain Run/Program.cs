using System;

namespace _02._Mountain_Run
{
	class Program
	{
		static void Main(string[] args)
		{
			double record = double.Parse(Console.ReadLine());
			double distance = double.Parse(Console.ReadLine());
			double timeFor1Meter = double.Parse(Console.ReadLine());
			double dalay = distance / 50;
			dalay = Math.Floor(dalay);
			double totoalTime = distance * timeFor1Meter + dalay * 30;
			if (totoalTime<record)
			{
				Console.WriteLine($"Yes! The new record is {totoalTime:f2} seconds.");
			}
			else
			{
				totoalTime = record - totoalTime;
				totoalTime = Math.Abs(totoalTime);
				Console.WriteLine($"No! He was {totoalTime:f2} seconds slower.");
			}

		}
	}
}
