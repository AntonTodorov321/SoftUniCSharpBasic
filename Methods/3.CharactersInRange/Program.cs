using System;

namespace _3.CharactersInRange
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstChar = char.Parse(Console.ReadLine());
			char secondChar = char.Parse(Console.ReadLine());
			PrintChar(firstChar, secondChar);
		}

		 static void PrintChar(char firstChar, char secondChar)
		{
			int startChar = Math.Min(firstChar, secondChar);
			int endChar = Math.Max(firstChar, secondChar);
			for (int i = startChar+1; i <= endChar-1; i++)
			{
				Console.Write((char)i + " ");
			}

		}
	}
}
