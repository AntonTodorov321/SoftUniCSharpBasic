using System;

namespace _05._Vacation
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			string plaseForRers = "";
			string destination = "";
			double totoalSum = 0;
			if (bujet<=1000)
			{
				plaseForRers = "Camp";
				if (season=="Summer")
				{
					destination = "Alaska";
					totoalSum = bujet * 0.65;
				}
				else
				{
					destination = "Morocco";
					totoalSum = bujet * 0.45;
				}
			}
			else if (bujet <= 3000)
			{
				plaseForRers = "Hut";
				if (season == "Summer")
				{
					destination = "Alaska";
					totoalSum = bujet * 0.8;
				}
				else
				{
					destination = "Morocco";
					totoalSum = bujet * 0.6;
				}
			}
			else
			{
				plaseForRers = "Hotel";
				if (season == "Summer")
					destination = "Alaska";
				else
					destination = "Morocco";
					totoalSum = bujet * 0.9;

			}
			Console.WriteLine($"{destination} - {plaseForRers} - {totoalSum:f2}");
		}
	}
}
