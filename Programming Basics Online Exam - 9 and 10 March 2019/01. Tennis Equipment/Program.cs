using System;

namespace _01._Tennis_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double tennusRalletsPrice = double.Parse(Console.ReadLine());
			int tennisRalletsCount = int.Parse(Console.ReadLine());
			int shooesCount = int.Parse(Console.ReadLine());
			double shooesPrice = 1 / 6.0 * tennusRalletsPrice;
			double anotherEquipment = (tennisRalletsCount * tennusRalletsPrice) + (shooesCount * shooesPrice);
			anotherEquipment *= 0.2;
			double totoalSum = (tennisRalletsCount * tennusRalletsPrice) + (shooesCount * shooesPrice) + anotherEquipment;
			double priceForTennisist = (1 / 8.0) * totoalSum;
			double priceForAgency = totoalSum - priceForTennisist;
			priceForTennisist = Math.Floor(priceForTennisist);
			priceForAgency = Math.Ceiling(priceForAgency);
			Console.WriteLine($"Price to be paid by Djokovic {priceForTennisist}");
			Console.WriteLine($"Price to be paid by sponsors {priceForAgency}");


		}
	}
}
