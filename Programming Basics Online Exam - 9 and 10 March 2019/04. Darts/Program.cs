using System;

namespace _04._Darts
{
	class Program
	{
		static void Main(string[] args)
		{
			string namePlayer = Console.ReadLine();
			string command;
			int totoalPoint = 301;
			int successfulShot = 0;
			int unsuccessfulShot = 0;
			bool isWon = false;
			while ((command=Console.ReadLine())!= "Retire")
			{
				int points = int.Parse(Console.ReadLine());
				if (command== "Double")
				{
					points *= 2;
				}
				else if(command== "Triple")
				{
					points *= 3;
				}
				if (totoalPoint<points)
				{
					while (points > totoalPoint)
					{
						unsuccessfulShot++;
						command = Console.ReadLine();
						if (command=="Retire")
						{
							break;
						}
						points = int.Parse(Console.ReadLine());
						if (command == "Double")
						{
							points *= 2;
						}
						else if (command == "Triple")
						{
							points *= 3;
						}
					}
				}
				if (command== "Retire")
				{
					break;
				}
				totoalPoint -= points;
				successfulShot++;
				if (totoalPoint<=0)
				{
					Console.WriteLine($"{namePlayer} won the leg with {successfulShot} shots.");
					isWon = true;
					break;
				}

			}
			if (!isWon)
			{
				Console.WriteLine($"{namePlayer} retired after {unsuccessfulShot} unsuccessful shots.");
			}
		}
	}
}
