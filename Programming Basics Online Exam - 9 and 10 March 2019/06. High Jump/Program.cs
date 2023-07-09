using System;

namespace _06._High_Jump
{
	class Program
	{
		static void Main(string[] args)
		{
			int targetHight = int.Parse(Console.ReadLine());
			int startHight = targetHight - 30;
			int successfullJump = 0;
			int unsuccessfullJumpCounter = 0;
			double height = 0;
			int totoalUnsuccessfullJump = 0;
			for (int i = startHight; i <= targetHight; i+=5)
			{
				height = i;
				unsuccessfullJumpCounter = 0;
				for (int unsuccessfulJump = 0; unsuccessfulJump < 3; unsuccessfulJump++)
				{
					int currentJump = int.Parse(Console.ReadLine());
					if (currentJump>i)
					{
						successfullJump++;
						break;
					}
					else
					{
						unsuccessfullJumpCounter++;
						totoalUnsuccessfullJump++;
					}
				}
				if (unsuccessfullJumpCounter>=3)
				{
					Console.WriteLine($"Tihomir failed at {i}cm after {successfullJump+totoalUnsuccessfullJump} jumps.");
					return;
				}
			}
			Console.WriteLine($"Tihomir succeeded, he jumped over {height}cm after {successfullJump+totoalUnsuccessfullJump} jumps.");
		}
	}
}
