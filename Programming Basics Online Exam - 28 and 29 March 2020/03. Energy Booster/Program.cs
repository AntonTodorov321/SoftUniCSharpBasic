using System;

namespace _03._Energy_Booster
{
	class Program
	{
		static void Main(string[] args)
		{
			string fruit = Console.ReadLine();
			string size = Console.ReadLine();
			int countGel = int.Parse(Console.ReadLine());
			double pricePerGel = 0;
			double totoalSum = 0;
			switch (size)
			{
				case "small":
					switch (fruit)
					{
						case "Watermelon":
							pricePerGel = 56;
							break;
						case "Mango":
							pricePerGel = 36.66;
							break;
						case "Pineapple":
							pricePerGel = 42.1;
							break;
						case "Raspberry":
							pricePerGel = 20;
							break;
					}
					totoalSum = pricePerGel * countGel * 2;
					break;
				case "big":
					switch (fruit)
					{
						case "Watermelon":
							pricePerGel = 28.7;
							break;
						case "Mango":
							pricePerGel = 19.6;
							break;
						case "Pineapple":
							pricePerGel = 24.8;
							break;
						case "Raspberry":
							pricePerGel = 15.2;
							break;

					}
					totoalSum = pricePerGel * countGel * 5;
					break;
			}
			if (totoalSum>1000)
			{
				totoalSum *= 0.5;
			}
			else if (totoalSum>=400)
			{
				totoalSum *= 0.85;
			}
			Console.WriteLine($"{totoalSum:f2}lv.");
		}
	}
}
