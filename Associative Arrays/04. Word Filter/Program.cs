﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			List<string> filtredWord = words.Where(word => word.Length % 2 == 0).ToList();
			foreach (var item in filtredWord)
			{
				Console.WriteLine(item);
			}
		}
	}
}
