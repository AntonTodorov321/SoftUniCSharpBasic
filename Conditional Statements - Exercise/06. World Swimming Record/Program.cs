using System;

namespace _06._World_Swimming_Record
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double worldRecord = double.Parse(Console.ReadLine());
			double metersSwimming = double.Parse(Console.ReadLine());
			double timeFor1Meter = double.Parse(Console.ReadLine());
			double timeForAllMeters = metersSwimming * timeFor1Meter;
			double slowTime = Math.Floor(metersSwimming / 15) * 12.5;
			double totalTime = timeForAllMeters + slowTime;
			double neededseconds = totalTime-worldRecord;
			if (totalTime <worldRecord)
			{
				Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
			}
			else
			{
				Console.WriteLine($"No, he failed! He was {neededseconds:f2} seconds slower.");
			}

		}
	}
}
