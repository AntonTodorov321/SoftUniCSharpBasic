using System;

namespace _05._Number_100to200
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numer = int.Parse(Console.ReadLine());
			if (numer<100)
			{
				Console.WriteLine("Less than 100");
			}
			else if (numer<=200)
			{
				Console.WriteLine("Between 100 and 200");
			}
			else
			{
				Console.WriteLine("Greater than 200");
			}
		}
	}
}
