using System;

namespace _03._Aluminum_Joinery
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.Брой дограми – цяло число в интервала[0..1000];
			//2.Вид на дограмите – текст "90X130" или "100X150" или "130X180" или "200X300";
			//			3.Начин на получаване – текст
			//•	С доставка -"With delivery"
			//•	Без доставка -"Without delivery"
			int countJoinery = int.Parse(Console.ReadLine());
			string typeJoinery = Console.ReadLine();
			string typeDelivary = Console.ReadLine();
			double priceJoinery = 0;
			if (countJoinery<=10)
			{
				Console.WriteLine("Invalid order");
				return;
			}
			switch (typeJoinery)
			{
				case "90X130":
					priceJoinery = 110;
					if (countJoinery<60 && countJoinery>30)
					{
						priceJoinery *= 0.95;
					}
					else if(countJoinery>60)
					{
						priceJoinery *= 0.92;
					}
					break;
				case "100X150":
					priceJoinery = 140;
					if (countJoinery < 80 && countJoinery > 40)
					{
						priceJoinery *= 0.94;
					}
					else if (countJoinery > 80)
					{
						priceJoinery *= 0.9;
					}
					break;
					case "130X180":
					priceJoinery = 190;
					if (countJoinery < 50 && countJoinery > 20)
					{
						priceJoinery *= 0.93;
					}
					else if (countJoinery > 50)
					{
						priceJoinery *= 0.88;
					}
					break;
				case "200X300":
					priceJoinery = 250;
					if (countJoinery < 50 && countJoinery > 25)
					{
						priceJoinery *= 0.91;
					}
					else if (countJoinery > 50)
					{
						priceJoinery *= 0.86;
					}
					break;
					
			}
			priceJoinery *= countJoinery;
			if (countJoinery>99)
			{
				if (typeDelivary== "With delivery")
				{
					priceJoinery += 60;
					priceJoinery *= 0.96;
				}
			}
			if (typeDelivary == "With delivery" && countJoinery<99)
			{
				priceJoinery += 60;
			}
			Console.WriteLine($"{priceJoinery:f2} BGN");
		}
	}
}
