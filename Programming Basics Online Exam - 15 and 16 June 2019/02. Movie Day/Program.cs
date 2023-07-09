using System;

namespace _02._Movie_Day
{
	class Program
	{
		static void Main(string[] args)
		{
			int timeForPictures = int.Parse(Console.ReadLine());
			int scenes = int.Parse(Console.ReadLine());
			int timeFor1Scenes = int.Parse(Console.ReadLine());
			double totoalTime = scenes * timeFor1Scenes;
			totoalTime += timeForPictures * 0.15;
			if (timeForPictures>totoalTime)
			{
				Console.WriteLine($"You managed to finish the movie on time! You have {Math.Floor( timeForPictures-totoalTime)} minutes left!");
			}
			else
			{
				Console.WriteLine($"Time is up! To complete the movie you need {Math.Floor(totoalTime - timeForPictures)} minutes.");
			}
		}
	}
}
