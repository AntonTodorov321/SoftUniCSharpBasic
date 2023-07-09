using System;

namespace _02._Easter_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			double envelopePrise = double.Parse(Console.ReadLine());
			double bujet = double.Parse(Console.ReadLine());
			double cakePrice = bujet * 0.1;
			if (peopleCount>=10 && peopleCount<=15)
			{
				envelopePrise *= 0.85;
			}
			else if (peopleCount>15 && peopleCount<=20)
			{
				envelopePrise *= 0.8;
			}
			else if(peopleCount>20)
			{
				envelopePrise *= 0.75;
			}
			double totoalSum = peopleCount * envelopePrise+cakePrice;
			if (bujet>=totoalSum)
			{
				Console.WriteLine($"It is party time! {bujet-totoalSum:f2} leva left.");
			}
			else
			{
				Console.WriteLine($"No party! {totoalSum-bujet:f2} leva needed.");
			}
		}
	}
}
