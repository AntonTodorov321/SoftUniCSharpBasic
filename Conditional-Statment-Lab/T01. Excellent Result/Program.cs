﻿using System;

namespace T01._Excellent_Result
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double grade = double.Parse(Console.ReadLine());
			if ( grade>=5.5)
			{
				Console.WriteLine("Excellent!");
			}
		}
	}
}
