using System;

namespace _04._Balls
{
	class Program
	{
		static void Main(string[] args)
		{
			int balls = int.Parse(Console.ReadLine());
			int redBallsCounter = 0;
			int orangeBallsCounter = 0;
			int yellowBallsCounter = 0;
			int whiteBallsCounter = 0;
			int blackBallsCounter = 0;
			int anotherBalls = 0;
			int totalBalls = 0;
			double totoalPoints = 0;
			for (int counterBalls = 0; counterBalls < balls; counterBalls++)
			{
				string collorBalls = Console.ReadLine();
				totalBalls++;
				if (collorBalls == "red")
				{
					redBallsCounter++;
					totoalPoints += 5;
				}
				else if (collorBalls == "orange")
				{
					orangeBallsCounter++;
					totoalPoints += 10;
				}
				else if (collorBalls == "yellow")
				{
					yellowBallsCounter++;
					totoalPoints += 15;
				}
				else if (collorBalls == "white")
				{
					whiteBallsCounter++;
					totoalPoints += 20;
				}
				else if (collorBalls == "black")
				{
					blackBallsCounter++;
					Math.Floor(totoalPoints /=2);
				}
				else
				{
					anotherBalls++;
				}
			}
			Console.WriteLine($"Total points: {Math.Floor(totoalPoints)}");
			Console.WriteLine($"Red balls: {redBallsCounter}");
			Console.WriteLine($"Orange balls: {orangeBallsCounter}");
			Console.WriteLine($"Yellow balls: {yellowBallsCounter}");
			Console.WriteLine($"White balls: {whiteBallsCounter}");
			Console.WriteLine($"Other colors picked: {anotherBalls}");
			Console.WriteLine($"Divides from black balls: {blackBallsCounter}");
		}
	}
}
