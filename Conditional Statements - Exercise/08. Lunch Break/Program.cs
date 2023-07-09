	using System;

	namespace _08._Lunch_Break
	{
		internal class Program
		{
			static void Main(string[] args)
			{
				string serialNmae = Console.ReadLine();
				int episodeMinets = int.Parse(Console.ReadLine());
				int breakMinets = int.Parse(Console.ReadLine());
				double lunchTime = breakMinets * 0.125;
				double restTime = breakMinets * 0.25;
				double leftTime = breakMinets - (lunchTime + restTime);
				double timeAfterWatching = Math.Ceiling( leftTime - episodeMinets);
				double needTime = Math.Ceiling(episodeMinets - leftTime)  ;
				if (episodeMinets<=leftTime)
				{
					Console.WriteLine($"You have enough time to watch {serialNmae} and left with {timeAfterWatching} minets free time.");
				}
				else
				{
					Console.WriteLine($"You don't have enough time to watch {serialNmae}, you need {needTime} more minets.");
				}
			}
		}
	}
