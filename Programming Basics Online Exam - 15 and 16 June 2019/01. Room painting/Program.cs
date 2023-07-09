using System;

namespace _01._Room_painting
{
	class Program
	{
		static void Main(string[] args)
		{
				int countBoxPaint = int.Parse(Console.ReadLine());
				int countRollers = int.Parse(Console.ReadLine());
			double priceGloves = double.Parse(Console.ReadLine());
			double priceBrush = double.Parse(Console.ReadLine());
			double glovesCount = Math.Ceiling(countRollers * 0.35);
			double brushCount = Math.Floor(countBoxPaint * 0.48);
			double totoalSum = countBoxPaint * 21.5 + countRollers * 5.2 + priceGloves * glovesCount + priceBrush * brushCount;
			totoalSum *= 1 / 15.0;
			Console.WriteLine($"This delivery will cost {totoalSum:f2} lv.");

		}
	}
}
