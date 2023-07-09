using System;

namespace _5.AddAndSubtract
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			int addedNum = AddNum(num1, num2);
			int result = SubtractNum(addedNum, num3);
			Console.WriteLine(result);
		}

		static int SubtractNum(int addedNum, int num3) => addedNum - num3;

		static int AddNum(int num1, int num2) => num1 + num2;
	}
}
