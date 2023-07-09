using System;

namespace _04._Car_To_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			string classCar = "";
			string typeCar = "";
			double totalSum = 0;
			////•	При бюджет по - малък или равен от 100лв.:
			if (bujet<=100)
			{
				classCar = "Economy class";
				if (season=="Summer")
				{
					typeCar = "Cabrio";
					totalSum = bujet * 0.35;
				}
				else
				{
					typeCar = "Jeep";
					totalSum = bujet * 0.65;
				}
			}
			////•	При бюджет по - голям от 100лв.и по-малък или равен от 500лв.:
			else if (bujet<=500)
			{
				classCar = "Compact class";
				if (season == "Summer")
				{
					typeCar = "Cabrio";
					totalSum = bujet * 0.45;
				}
				else
				{
					typeCar = "Jeep";
					totalSum = bujet * 0.8;
				}
			}
			else
			{
				classCar = "Luxury class";
				typeCar = "Jeep";
				totalSum = bujet * 0.9;
			}
			Console.WriteLine(classCar);
			Console.WriteLine($"{typeCar} - {totalSum:f2}");
			////•	При бюджет по - голям от 500лв.:
			////o Класът ще е – "Luxury class"
			////o За всеки сезон колата ще е джип и цената ще е:
			////	90 % от бюджета

		}
	}
}
