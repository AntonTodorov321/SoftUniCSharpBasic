using System;

namespace _05._Journey
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			string destinatin = " ";
			double priseDestinatin =0;
			string plaseForRest = "";
			if (bujet <= 100)
			{
				if (season == "summer")
				{
					priseDestinatin = bujet - (bujet * 0.3);
				}
				else if (season == "inter")
				{
					priseDestinatin = bujet - (bujet * 0.7);
				}
				destinatin = "Somewhere in Bulgaria";
			}
			else if (bujet <= 1000)
			{
				if (season == "summer")
				{
					priseDestinatin = bujet - (bujet * 0.4);
				}
				else if (season == "winter")
				{
					priseDestinatin = bujet - (bujet * 0.8);
				}
				destinatin = "Somewhere in Balkans";
			}
			else if (bujet > 1000)
			{
				priseDestinatin = bujet - (bujet * 0.9);
				destinatin = "Somewhere in Europe";

			}

			//Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
			if (season=="summer")
			{
				plaseForRest = "Camp";
			}
			else if (season == "winter")
			{
				plaseForRest = "Hotel";
			}
			if (destinatin== "Somewhere in Europe")
			{
				plaseForRest = "Hotel";
			}

			//Изход
			//На конзолата трябва да се отпечатат два реда.
			//•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
			Console.WriteLine($"{destinatin}");
			//•	Втори ред – “{ Вид почивка} – { Похарчена сума}“
			Console.WriteLine($"{plaseForRest} - {bujet-priseDestinatin:f2}");
			//o Почивката може да е между „Camp” и „Hotel”
			//o Сумата трябва да е закръглена с точност до вторият знак след запетаята.

		}
	}
}
