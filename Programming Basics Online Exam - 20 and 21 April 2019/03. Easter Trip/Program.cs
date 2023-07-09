using System;

namespace _03._Easter_Trip
{
	class Program
	{
		static void Main(string[] args)
		{
			string destination = Console.ReadLine();
			string date = Console.ReadLine();
			int nightsCount = int.Parse(Console.ReadLine());
			double priceForNights = 0;
			switch (destination)
			{
				case "France":
					if (date == "21-23")
					{
						priceForNights = 30;
					}
					else if (date == "24-27")
					{
						priceForNights = 35;
					}
					else
					{
						priceForNights = 40;
					}
					break;
				case "Italy":
					if (date == "21-23")
					{
						priceForNights = 28;
					}
					else if (date == "24-27")
					{
						priceForNights = 32;
					}
					else
					{
						priceForNights = 39;
					}
					break;
				case "Germany":
					if (date == "21-23")
					{
						priceForNights = 32;
					}
					else if (date == "24-27")
					{
						priceForNights = 37;
					}
					else
					{
						priceForNights = 43;
					}
					break;
			}
			Console.WriteLine($"Easter trip to {destination} : {nightsCount*priceForNights:f2} leva.");
		}
	}
}
