using System;

namespace _01._Series_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string serialName = Console.ReadLine();
			int countSeazon = int.Parse(Console.ReadLine());
			int countEpisode = int.Parse(Console.ReadLine());
			double timeForEpisode = double.Parse(Console.ReadLine());
			timeForEpisode += timeForEpisode * 0.2;
			double totoalTime = countEpisode * countSeazon * timeForEpisode;
			totoalTime += countSeazon * 10;
			Console.WriteLine($"Total time needed to watch the {serialName} series is {Math.Floor(totoalTime)} minutes.");

		}
	}
}
