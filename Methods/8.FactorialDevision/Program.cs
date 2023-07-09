using System;

namespace _8.FactorialDevision
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());	
			int num2 = int.Parse(Console.ReadLine());
			int result1 = FacturialCalculate(num1);
			int result2 = FacturialCalculate(num2);
			PrintResult(result1, result2);
		}

		static void PrintResult(int result1, int result2) => Console.WriteLine($"{(result1/result2):f2}");

		static int FacturialCalculate(int num)
		{
			int result = 1;
			for (int i = num; i > 0; i--)
			{
				result *= i;
			}
			return result;
		}
	}
}
