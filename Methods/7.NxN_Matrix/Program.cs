using System;

namespace _7.NxN_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			PrintMatrix(num);
		}

		static void PrintMatrix(int num)
		{
			for (int i = 0; i < num; i++)
			{
				for (int b = 0; b < num; b++)
				{
					Console.Write(num+ " ");
				}
				Console.WriteLine();
			}
		}
	}
}
