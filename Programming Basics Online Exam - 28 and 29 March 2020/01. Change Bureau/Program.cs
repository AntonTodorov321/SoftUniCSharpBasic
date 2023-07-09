using System;

namespace _01._Change_Bureau
{
	class Program
	{
		static void Main(string[] args)
		{
			int bitCoint = int.Parse(Console.ReadLine());
			double chaineseYuna = double.Parse(Console.ReadLine());
			double commission = double.Parse(Console.ReadLine());
			double totoalLeva = bitCoint * 1168;
			double totoalDolar = chaineseYuna * 0.15;
			totoalLeva += totoalDolar * 1.76;
			double totalEvro = totoalLeva / 1.95;
			totalEvro -= totalEvro * (commission/100);
			Console.WriteLine($"{totalEvro:f2}");
		}
	}
}
