using System;

namespace _01._Cinema
{
	class Program
	{
		static void Main(string[] args)
		{
			//			В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.Има три вида прожекции с билети на различни цени:
			//•	Premiere – премиерна прожекция, на цена 12.00 лева.
			//•	Normal – стандартна прожекция, на цена 7.50 лева.
			//•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
			//Напишете програма, която чете тип прожекция(стринг), брой редове и брой колони в залата(цели числа), въведени от потребителя, и изчислява общите приходи от билети при пълна зала.Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.  
			string project = Console.ReadLine();
			double row = double.Parse(Console.ReadLine());
			double colums = double.Parse(Console.ReadLine());
			double totalSum = 0;
			if (project== "Premiere")
			{
				totalSum = (row * colums) * 12;
			}
			else if (project == "Normal")
			{
				totalSum = (row * colums) * 7.5;
			}
			else
				totalSum = (row * colums) * 5;
			Console.WriteLine($"{totalSum:f2} leva");

		}
	}
}
