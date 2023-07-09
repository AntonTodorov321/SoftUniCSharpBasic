using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfLines = int.Parse(Console.ReadLine());
			Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

			for (int i = 0; i < countOfLines; i++)
			{
				string currWord = Console.ReadLine();
				string currSynonym = Console.ReadLine();

				if (! synonyms.ContainsKey(currWord))
				{
					synonyms[currWord] = new List<string>();
				}
				synonyms[currWord].Add(currSynonym);
			}

			foreach (var word in synonyms)
			{
				Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
			}
		}
	}
}
