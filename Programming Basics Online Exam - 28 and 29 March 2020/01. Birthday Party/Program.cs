using System;

namespace _01._Birthday_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			double rentRoom = double.Parse(Console.ReadLine());
			double cake = rentRoom * 0.2;
			double drink = cake - (cake * 0.45);
			double animator = 1 / 3.0 * rentRoom;
			Console.WriteLine($"{rentRoom+cake+drink+animator}");
		}
	}
}
