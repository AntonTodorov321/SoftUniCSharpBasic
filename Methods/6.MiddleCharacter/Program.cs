using System;

namespace _6.MiddleCharacter
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			PrintMiddleCharacters(text);
		}

		static void PrintMiddleCharacters(string text)
		{
				if (text.Length%2==0)
				{
					Console.Write(text[text.Length/2-1]);
					Console.Write(text[text.Length/2]);
				}
				else
				{
					Console.WriteLine(text[text]);
				}
		}
	}
}
