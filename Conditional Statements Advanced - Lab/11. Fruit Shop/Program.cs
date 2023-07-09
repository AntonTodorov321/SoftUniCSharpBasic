using System;

namespace _11._Fruit_Shop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Напишете програма, която чете от конзолата плод(banana / apple / orange / grapefruit / kiwi / pineapple / grapes), ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество(реално число) , въведени от потребителя, и пресмята цената според цените от таблиците по-горе.Резултатът да се отпечата закръглен с 2 цифри след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "error".
			string fruit = Console.ReadLine();
			string dayOfWeek = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());
			double totalSum =0;
			//			плод banana  apple   orange  grapefruit kiwi    pineapple grapes
			//цена            2.50    1.20    0.85    1.45      2.70    5.50       3.85

			if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
			{
				switch (fruit)
				{
					case "banana":
						totalSum = quantity * 2.5;
						break;
					case "apple":
						totalSum = quantity * 1.2;
						break;
					case "orange":
						totalSum = quantity * 0.85;
						break;
					case "grapefruit":
						totalSum = quantity * 1.45;
						break;
					case "kiwi":
						totalSum = quantity * 2.7;
						break;
					case "pineapple":
						totalSum = quantity * 5.5;
						break;
					case "grapes":
						totalSum = quantity * 3.85;
						break;
					default:
						Console.WriteLine("error");
						break;
				}

			}
			else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
			{
				switch (fruit)
				{
					case "banana":
						totalSum = quantity * 2.7;
						break;
					case "apple":
						totalSum = quantity * 1.25;
						break;
					case "orange":
						totalSum = quantity * 0.90;
						break;
					case "grapefruit":
						totalSum = quantity * 1.60;
						break;
					case "kiwi":
						totalSum = quantity * 3;
						break;
					case "pineapple":
						totalSum = quantity * 5.6;
						break;
					case "grapes":
						totalSum = quantity * 4.2;
						break;
					default:
						Console.WriteLine("error");
						break;
				}
			}
			else
				Console.WriteLine("error");
			if (totalSum>0)
			Console.WriteLine($"{totalSum:f2}");
		}
	}
}
