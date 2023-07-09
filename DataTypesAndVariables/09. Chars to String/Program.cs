using System;

namespace _09._Chars_to_String
{
	class Program
	{
		static void Main(string[] args)
		{
			char someChar1 = char.Parse(Console.ReadLine());
			char someChar2 = char.Parse(Console.ReadLine());
			char someChar3 = char.Parse(Console.ReadLine());
			Console.WriteLine($"{someChar1}{someChar2}{someChar3}");
		}
	}
}
