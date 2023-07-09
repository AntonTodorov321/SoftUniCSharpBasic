using System;

namespace _04._Club
{
	class Program
	{
		static void Main(string[] args)
		{
			double target = double.Parse(Console.ReadLine());
			string coctailName;
			bool isReach = false;
			double totoalSum = 0;
			while ((coctailName=Console.ReadLine())!= "Party!")
			{
				double currentSum = 0;
				int countCoctail = int.Parse(Console.ReadLine());
				int priceCoctail = coctailName.Length;
				currentSum += countCoctail * priceCoctail;
				if (currentSum % 2!=0)
				{
					currentSum *= 0.75;
				}
				totoalSum += currentSum;
				if (totoalSum>=target)
				{
					isReach = true;
					break;
				}

			}
			if (!isReach)
			{
				Console.WriteLine($"We need {target-totoalSum:f2} leva more.");
			}
			else
			{
				Console.WriteLine("Target acquired.");
			}
				Console.WriteLine($"Club income - {totoalSum:f2} leva.");
		}
	}
}
