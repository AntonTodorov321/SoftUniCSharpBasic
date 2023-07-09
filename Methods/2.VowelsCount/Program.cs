using System;
using System.Linq;

namespace _2.VowelsCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine().ToLower();
			Console.WriteLine(VowelsCount(text));
		}

		static int VowelsCount(string text)
		{
			return text.Count(vowels => "aouei".Contains(vowels));
		}
	}
}
