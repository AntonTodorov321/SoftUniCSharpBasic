using System;

namespace Exercise_Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			int secondNum = int.Parse(Console.ReadLine());
			int tirdNum = int.Parse(Console.ReadLine());
			Console.WriteLine(SmmalestNum(firstNum, secondNum, tirdNum)) ;
		}

		static int SmmalestNum(int firstNum, int secondNum, int tirdNum) =>Math.Min(firstNum, Math.Min(secondNum, tirdNum));
	}
}
