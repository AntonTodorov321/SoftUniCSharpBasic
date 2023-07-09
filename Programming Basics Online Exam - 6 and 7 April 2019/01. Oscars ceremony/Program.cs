using System;

namespace _01._Oscars_ceremony
{
	class Program
	{
		static void Main(string[] args)
		{
			int rentRoom = int.Parse(Console.ReadLine());
			double sum1 = rentRoom - (rentRoom * 0.3);
			double sum2 = sum1 - (sum1 * 0.15);
			double sum3 = sum2 * 0.5;
			double totalSum = sum1 + sum2 + sum3 + rentRoom;
			Console.WriteLine($"{totalSum:f2}");
		}
	}
}
