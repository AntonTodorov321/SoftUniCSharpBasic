using System;

namespace _04._Gifts_from_Santa
{
	class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int end = int.Parse(Console.ReadLine());
			int wrong = int.Parse(Console.ReadLine());
			for (int counter = end; counter >=start ; counter--)
			{
				if (counter==wrong && counter % 2 == 0 && counter % 3 == 0)
				{
					break;
				}
				if (counter%2==0 && counter%3==0)
				{
					Console.Write($"{counter} ");
				}
			}
		}
	}
}
