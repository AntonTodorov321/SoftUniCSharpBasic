using System;

namespace _01._Basketball_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			int yearTax = int.Parse(Console.ReadLine());
			double shoes = yearTax * 0.6;
			double outfit = shoes * 0.8;
			double ball = 0.25 * outfit;
			double accessories = (1 / 5.0) * ball;
			double totoalSum = yearTax + outfit + shoes + ball + accessories;
			Console.WriteLine($"{totoalSum:f2}");
		}
	}
}
