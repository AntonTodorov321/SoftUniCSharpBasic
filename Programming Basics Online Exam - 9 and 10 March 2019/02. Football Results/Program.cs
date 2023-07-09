using System;

namespace _02._Football_Results
{
	class Program
	{
		static void Main(string[] args)
		{

			int minQuota = int.Parse(Console.ReadLine());
			int secQuota = int.Parse(Console.ReadLine());
			double lenghtBeehive = double.Parse(Console.ReadLine());
			int secFor100Meters = int.Parse(Console.ReadLine());
			double totoalQuota = minQuota * 60 + secQuota;
			double timeSlow = lenghtBeehive / 120.0;
			double totalSlowTime = timeSlow * 2.5;
			double totoalTime = (lenghtBeehive / 100.0) * secFor100Meters - totalSlowTime;
			if (totoalTime<=totoalQuota)
			{
				Console.WriteLine($"Marin Bangiev won an Olympic quota!");
				Console.WriteLine($"His time is {totoalTime:f3}.");
			}
			else
			{
				Console.WriteLine($"No, Marin failed! He was {totoalTime-totoalQuota:f3} second slower.");
			}


		}
	}
}
