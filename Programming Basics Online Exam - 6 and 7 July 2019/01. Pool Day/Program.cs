using System;

namespace _01._Pool_Day
{
	class Program
	{
		static void Main(string[] args)
		{

			int peopleCount = int.Parse(Console.ReadLine());
			double tax = double.Parse(Console.ReadLine());
			double priceForDeckChair = double.Parse(Console.ReadLine());
			double umbrella = double.Parse(Console.ReadLine());
			double umbrellaCount = peopleCount * 0.75;
			umbrellaCount = Math.Ceiling(umbrellaCount);
			double deckChairCount = peopleCount / 2.0;
			deckChairCount = Math.Ceiling(deckChairCount);
			double totoalSum = peopleCount * tax + umbrellaCount * priceForDeckChair + deckChairCount * umbrella;
			Console.WriteLine($"{totoalSum:f2} lv.");
		}
	}
}
