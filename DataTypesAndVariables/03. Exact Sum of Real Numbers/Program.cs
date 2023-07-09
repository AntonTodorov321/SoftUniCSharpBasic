using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfNum = int.Parse(Console.ReadLine());
			decimal sum = 0;
			for (int i = 0; i < countOfNum; i++)
			{
				decimal currentNum = decimal.Parse(Console.ReadLine());
				sum += currentNum;
			}
			Console.WriteLine(sum);
		}
	}
}
