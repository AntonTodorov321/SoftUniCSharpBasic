using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> sequensesOfWord = Console.ReadLine().Split().Select(word => word.ToLower()).ToList();
			Dictionary<string, int> oddOccurrencec = new Dictionary<string, int>();

			foreach (var word in sequensesOfWord)
			{
				if (!oddOccurrencec.ContainsKey(word))
				{
					oddOccurrencec[word] = 0;
				}
				oddOccurrencec[word]++;
			}

			string[] oddOccurrencesCount = oddOccurrencec.Where(word => word.Value % 2 != 0).Select(word=>word.Key).ToArray();
			Console.WriteLine(string.Join(" ",oddOccurrencesCount));

		}
	}
}
