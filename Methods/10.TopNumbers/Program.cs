using System;

namespace _10.TopNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			PrintTopInteger(num);
		}

		static void PrintTopInteger(int num)
		{
			for (int i = 1; i <= num; i++)
			{
				bool isSumOfDigitIsDevisibleByEight = SumOfDigit(i);
				bool isAtleatOneOddDigit = OddDigit(i);
				if (isSumOfDigitIsDevisibleByEight && isAtleatOneOddDigit)
				{
					Console.WriteLine(i);
				}
			}
		}

		static bool OddDigit(int i)
		{
			int counter = 0;
			while (i>0)
			{
				int currentDigit = i % 10;
				i /= 10;
				if (i%2!=0)
				{
					counter++;
				}
			}
			return counter >= 1;
		}

		private static bool SumOfDigit(int i)
		{
			int sumOfDigit = 0;
			while (i > 0)
			{
				sumOfDigit += i % 10;
				i /= 10;
			}
			return sumOfDigit % 8 == 0;

		}
	}
}
