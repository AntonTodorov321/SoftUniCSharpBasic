using System;

namespace _03._New_House
{
	class Program
	{
		static void Main(string[] args)
		{
			//Съществуват следните отстъпки:
			//•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
			//•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
			//•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
			//•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
			//•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
			string flowerKind = Console.ReadLine();
			int flowerCount = int.Parse(Console.ReadLine());
			int buget = int.Parse(Console.ReadLine());
			double totoalSum = 0;
			switch (flowerKind)
			{
				case "Roses":
					totoalSum = flowerCount * 5;
					break;
				case "Dahlias":
					totoalSum = flowerCount * 3.8;
					break;
				case "Tulips":
					totoalSum = flowerCount * 2.8;
					break;
				case "Narcissus":
					totoalSum = flowerCount * 3;
					break;
				case "Gladiolus":
					totoalSum = flowerCount * 2.5;
					break;
				default:
					break;
			}
			//Съществуват следните отстъпки:
			if (flowerCount>80 && flowerKind== "Roses")
			{
				totoalSum *= 0.9;
			}
			else if (flowerCount > 90 && flowerKind == "Dahlias")
			{
				totoalSum *= 0.85;
			}
			else if (flowerCount > 80 && flowerKind == "Tulips")
			{
				totoalSum *= 0.85;
			}
			else if (flowerCount < 120 && flowerKind == "Narcissus")
			{
				totoalSum += (totoalSum * 0.15);
			}
			else if (flowerCount < 80 && flowerKind == "Gladiolus")
			{
				totoalSum = totoalSum + (totoalSum * 0.2);
			}
			//Да се отпечата на конзолата на един ред:
			if (buget>totoalSum)
			{
				Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerKind} and {buget-totoalSum:f2} leva left.");
			}
			else
			{
				Console.WriteLine($"Not enough money, you need {totoalSum-buget:f2} leva more.");
			}
			//•	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."

		}
	}
}
