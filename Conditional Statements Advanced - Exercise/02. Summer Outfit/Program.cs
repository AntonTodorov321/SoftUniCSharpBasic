using System;

namespace _02._Summer_Outfit
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Лято е с много променливо време и Виктор има нужда от вашата помощ.Напишете програма която спрямо времето от денонощието и градусите да препоръча на Виктор какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от таблицата.
			//От конзолата се четат точно два реда:
			//•	Градусите - цяло число в интервала[10…42]
			//•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"

			int degrees = int.Parse(Console.ReadLine());
			string timeFromDay = Console.ReadLine();
			string outFit;
			string shoes;


			if (timeFromDay == "Morning")
			{
				if (degrees <= 18)
				{
					outFit = "Sweatshirt";
					shoes = "Sneakers";
				}
				else if ( degrees <= 24)
				{
					outFit = "Shirt";
					shoes = "Moccasins";
				}
				else
				{
					outFit = "T-Shirt";
					shoes = "Sandals";
				}
			}
			else if (timeFromDay == "Afternoon")
			{
				if (degrees <= 18)
				{
					outFit = "Shirt";
					shoes = "Moccasins";
				}
				else if (degrees <= 24)
				{
					outFit = "T-Shirt";
					shoes = "Sandals";
				}
				else 
				{
					outFit = "Swim Suit";
					shoes = "Barefoot";
				}
			}
			else
			{
				outFit = "Shirt";
				shoes = "Moccasins";
			}
			Console.WriteLine($"It's {degrees} degrees, get your {outFit} and {shoes}.");
		}
	}
}
