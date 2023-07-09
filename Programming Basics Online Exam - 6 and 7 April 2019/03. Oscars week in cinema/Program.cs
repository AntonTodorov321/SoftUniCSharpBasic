using System;

namespace _03._Oscars_week_in_cinema
{
	class Program
	{
		static void Main(string[] args)
		{
			string moveName = Console.ReadLine();
			string typeRoom = Console.ReadLine();
			int countTicket = int.Parse(Console.ReadLine());
			double ticketPrice = 0;
			switch (moveName)
			{
				case "A Star Is Born":
					switch (typeRoom)
					{
						case "normal":
							ticketPrice = 7.5;
							break;
						case "luxury":
							ticketPrice = 10.5;
							break;
						case "ultra luxury":
							ticketPrice = 13.5;
							break;

					}
					break;
				case "Bohemian Rhapsody":
					switch (typeRoom)
					{
						case "normal":
							ticketPrice = 7.35;
							break;
						case "luxury":
							ticketPrice = 9.45;
							break;
						case "ultra luxury":
							ticketPrice = 12.75;
							break;

					}
					break;
				case "Green Book":
					switch (typeRoom)
					{
						case "normal":
							ticketPrice = 8.15;
							break;
						case "luxury":
							ticketPrice = 10.25;
							break;
						case "ultra luxury":
							ticketPrice = 13.25;
							break;

					}
					break;
				case "The Favourite":
					switch (typeRoom)
					{
						case "normal":
							ticketPrice = 8.75;
							break;
						case "luxury":
							ticketPrice = 11.55;
							break;
						case "ultra luxury":
							ticketPrice = 13.95;
							break;

					}
					break;
			}
			Console.WriteLine($"{moveName} -> {countTicket*ticketPrice:f2} lv.");
		}
	}
}
