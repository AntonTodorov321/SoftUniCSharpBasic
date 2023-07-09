using System;

namespace _05._Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int end = int.Parse(Console.ReadLine());
			for (int i = 1; i <= end; i++)
			{
				int currentNum = i;
				int sum = 0;
				while (currentNum>0)
				{
					int currentDigit = currentNum % 10;
					currentNum /= 10;
					sum += currentDigit;
				}
				if (sum==5 || sum==7 || sum==11)
				{
					Console.WriteLine($"{i} -> True");
				}
				else
				{
					Console.WriteLine($"{i} -> False");

				}
			}
		}
	}
}
