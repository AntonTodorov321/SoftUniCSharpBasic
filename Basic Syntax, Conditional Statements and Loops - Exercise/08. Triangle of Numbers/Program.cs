﻿using System;

namespace _08._Triangle_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			for (int i = 1; i <= num; i++)
			{
				for (int j = 1; j < i+1; j++)
				{
					Console.Write($"{i} ");
				}
				Console.WriteLine();
			}
		}
	}
}
