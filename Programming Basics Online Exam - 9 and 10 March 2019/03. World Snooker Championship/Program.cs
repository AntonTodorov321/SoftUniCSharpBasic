using System;

namespace _03._World_Snooker_Championship
{
	class Program
	{
		static void Main(string[] args)
		{
			string stageChampionship = Console.ReadLine();
			string ticketType = Console.ReadLine();
			int countTicket = int.Parse(Console.ReadLine());
			char picturesWithTrophy = char.Parse(Console.ReadLine());
			double ticketPrice = 0;
			if (stageChampionship == "Quarter final")
			{
				if (ticketType == "Standard")
				{
					ticketPrice = 55.5;
				}
				else if (ticketType == "Premium")
				{
					ticketPrice = 105.2;

				}
				else
				{
					ticketPrice = 118.9;
				}
			}
			if (stageChampionship == "Semi final")
			{
				if (ticketType == "Standard")
				{
					ticketPrice = 75.88;
				}
				else if (ticketType == "Premium")
				{
					ticketPrice = 125.22;

				}
				else
				{
					ticketPrice = 300.4;
				}
			}
			if (stageChampionship == "Final")
			{
				if (ticketType == "Standard")
				{
					ticketPrice = 110.1;
				}
				else if (ticketType == "Premium")
				{
					ticketPrice = 160.66;

				}
				else
				{
					ticketPrice = 400;
				}
			}
			double totoalSum = ticketPrice * countTicket;
			int picturesTropthy = 40;
			if (totoalSum<=4000 && totoalSum>2500)
			{
				totoalSum *= 0.9;
			}
			if (totoalSum>4000)
			{
				picturesTropthy = 0;
				totoalSum *= 0.75;
			}
			if (picturesWithTrophy=='Y')
			{
				totoalSum += picturesTropthy*countTicket;
			}
			Console.WriteLine($"{totoalSum:f2}");




		}
	}
}
