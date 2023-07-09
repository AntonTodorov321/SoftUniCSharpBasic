using System;

namespace _07._Area_of_Figures
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string figure = Console.ReadLine();
			if (figure == "square")
			{
				double lenght = double.Parse(Console.ReadLine());
				double resultOfSides = lenght * lenght;
				Console.WriteLine($"{resultOfSides:f3}");

			}
			else if (figure == "rectangle")
			{
				double sideA = double.Parse(Console.ReadLine());
				double sideB = double.Parse(Console.ReadLine());
				double resultOfSides = sideA * sideB;
				Console.WriteLine($"{resultOfSides:f3}");

			}
			else if (figure == "circle")
			{
				double radios = double.Parse(Console.ReadLine());
				double sum = radios * radios * Math.PI;
				Console.WriteLine($"{sum:f3}");

			}
			else if (figure == "triangle")
			{
				double sizeLenght = double.Parse(Console.ReadLine());
				double sizeHeight = double.Parse(Console.ReadLine());
				double sum = sizeHeight * sizeLenght/2;
				Console.WriteLine($"{sum:f3}");
			}
		}
	}
}
