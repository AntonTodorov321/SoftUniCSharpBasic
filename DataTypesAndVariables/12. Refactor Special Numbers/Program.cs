using System;

namespace _12._Refactor_Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
            int endTarget = int.Parse(Console.ReadLine());
            for (int num = 1; num <= endTarget; num++)
            {
                int currentNum = num;
                int totalSum = 0;
                while (currentNum > 0)
                {
                    totalSum += currentNum % 10;
                    currentNum /= 10;
                }
                bool isUpper = false;
                isUpper = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);
                Console.WriteLine("{0} -> {1}", num, isUpper);
            }

        }
    }
}
