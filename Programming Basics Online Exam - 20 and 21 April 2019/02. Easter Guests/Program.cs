using System;

namespace _02._Easter_Guests
{
	class Program
	{
		static void Main(string[] args)
		{
			int guests = int.Parse(Console.ReadLine());
			double bujet = double.Parse(Console.ReadLine());
			double easterBreadCount = guests / 3.0;
			easterBreadCount = Math.Ceiling(easterBreadCount);
			int eggsCount = guests * 2;
			double totoalSum = easterBreadCount * 4 + eggsCount * 0.45;
			if (bujet>=totoalSum)
			{
				Console.WriteLine($"Lyubo bought {easterBreadCount} Easter bread and {eggsCount} eggs.");
				Console.WriteLine($"He has {bujet-totoalSum:f2} lv. left.");
			}
			else
			{
				Console.WriteLine("Lyubo doesn't have enough money.");
				Console.WriteLine($"He needs {totoalSum-bujet:f2} lv. more.");
			}
		}
	}
}
