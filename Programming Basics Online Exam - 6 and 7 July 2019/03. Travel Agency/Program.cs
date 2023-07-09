using System;

namespace _03._Travel_Agency
{
	class Program
	{
		static void Main(string[] args)
		{
			string town = Console.ReadLine();
			string pakegeType = Console.ReadLine();
			string VIPDiscount = Console.ReadLine();
			int dayStay = int.Parse(Console.ReadLine());
			double price = 0;
			int discount = 0;
			if (town== "Bansko" || town== "Borovets")
			{
				if (pakegeType== "noEquipment")
				{
					if (VIPDiscount=="yes")
					{
						discount = 5;
					}
					price = 80;
				}
				else if (pakegeType== "withEquipment")
				{
					if (VIPDiscount == "yes")
					{
						discount = 10;
					}
					price = 100;
				}
				else
				{
					Console.WriteLine("Invalid input!");
					return;
				}
			}
			else if (town == "Varna" || town == "Burgas")
			{
				if (pakegeType== "withBreakfast")
				{
					if (VIPDiscount == "yes")
					{
						discount = 12;
					}
					price = 130;
				}
				else if (pakegeType== "noBreakfast")
				{
					if (VIPDiscount == "yes")
					{
						discount = 7;
					}
					price = 100;
				}
				else
				{
					Console.WriteLine("Invalid input!");
					return;
				}
			}
			else
			{
				Console.WriteLine("Invalid input!");
				return;
			}
			if (dayStay<1)
			{
				Console.WriteLine("Days must be positive number!");
				return;
			}
			if (dayStay>7)
			{
				dayStay--;
			}
			if (discount>0)
			{
				price -= price * (discount / 100.0);
			}
			double totoalSum = dayStay * price;
			Console.WriteLine($"The price is {totoalSum:f2}lv! Have a nice time!");
		}
	}
}
