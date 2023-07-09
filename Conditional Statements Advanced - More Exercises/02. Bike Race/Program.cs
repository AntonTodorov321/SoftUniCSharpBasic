using System;

namespace _02._Bike_Race
{
	class Program
	{
		static void Main(string[] args)
		{
			int juniorsCyclist = int.Parse(Console.ReadLine());
			int seniorsCyclist = int.Parse(Console.ReadLine());
			string route = Console.ReadLine();
			double totoalSum = 0;
			//Група      trail   cross - country   downhill road
			//juniors    5.50    8                 12.25    20
			//seniors     7      9.50              13.75    21.50
			switch (route)
			{
				case "trail":
					totoalSum = (juniorsCyclist * 5.5) + seniorsCyclist * 7;
					break;
				case "cross-country":
					totoalSum= (juniorsCyclist * 8) + seniorsCyclist * 9.5;
					break;
				case "downhill":
					totoalSum = (juniorsCyclist * 12.25) + seniorsCyclist * 13.75;
					break;
				default:
					totoalSum = (juniorsCyclist * 20) + seniorsCyclist * 21.5;
					break;
			}
			if (route == "cross-country" && (juniorsCyclist + seniorsCyclist) >= 50)
			{
				totoalSum *= 0.75;
			}
			totoalSum *= 0.95;
			Console.WriteLine($"{totoalSum:f2}");
		}
	}
}
