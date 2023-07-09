using System;
using System.Collections.Generic;
using System.Linq;

namespace LabAssociative_Arrays___Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
			SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

			foreach (var number in input)
			{
				if (!numbers.ContainsKey(number))
				{
					numbers.Add(number, 0);
				}

				numbers[number]++;
			}

			foreach (var number in numbers)
			{
				Console.WriteLine($"{number.Key} -> {number.Value}");
			}
		}
	}
}
