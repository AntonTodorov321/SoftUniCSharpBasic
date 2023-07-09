using System;

namespace _02._Add_Bags
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.Цената на багаж над 20кг - реално число в диапазона[10.0…80.0]
			//2.Килограми на багажа – реално число в диапазона[1.0…32.0]
			//3.Дни до пътуването – цяло число в диапазона[1…60]
			//4.Брой багажи – цяло число в диапазона[1…10]
			double priseFor20kgLuggage = double.Parse(Console.ReadLine());
			double kgLuggage = double.Parse(Console.ReadLine());
			int daysToGo = int.Parse(Console.ReadLine());
			int countLuggage =int.Parse(Console.ReadLine());
			double totoalKg = 0;
			if (kgLuggage<10)
			{
				totoalKg = priseFor20kgLuggage * 0.2;
			}
			else if (kgLuggage<=20)
			{
				totoalKg = priseFor20kgLuggage * 0.5;
			}
			else
			{
				totoalKg = priseFor20kgLuggage;
			}
			if (daysToGo<7)
			{
				totoalKg += totoalKg * 0.4;
			}
			else if (daysToGo<=30)
			{
				totoalKg += totoalKg * 0.15;
			}
			else
			{
				totoalKg += totoalKg * 0.1;
			}
			Console.WriteLine($"The total price of bags is: {totoalKg*countLuggage:f2} lv. ");
		}
	}
}
