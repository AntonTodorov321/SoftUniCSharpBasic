using System;

namespace _04._Food_for_Pets
{
	class Program
	{
		static void Main(string[] args)
		{
			int days = int.Parse(Console.ReadLine());
			double totoalFood = double.Parse(Console.ReadLine());
			double totoalEatenDogFood = 0;
			double totoalEatenCatFood = 0;
			double cookies = 0;
			for (int i = 1; i <= days; i++)
			{
				int eatenDogFood = int.Parse(Console.ReadLine());
				int eatenCatFood = int.Parse(Console.ReadLine());
				totoalEatenDogFood += eatenDogFood;
				totoalEatenCatFood += eatenCatFood;
				if (i%3==0)
				{
					cookies += (eatenCatFood + eatenDogFood) * 0.1;
				}
			}
			cookies = Math.Round(cookies);
			Console.WriteLine($"Total eaten biscuits: {cookies}gr.");
			Console.WriteLine($"{(totoalEatenCatFood+totoalEatenDogFood)/totoalFood*100:f2}% of the food has been eaten.");
			Console.WriteLine($"{(totoalEatenDogFood/(totoalEatenCatFood+totoalEatenDogFood))*100:f2}% eaten from the dog.");
			Console.WriteLine($"{(totoalEatenCatFood/ (totoalEatenCatFood + totoalEatenDogFood)) *100:f2}% eaten from the cat.");
		}
	}
}
