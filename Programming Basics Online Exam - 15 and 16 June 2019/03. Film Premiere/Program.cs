using System;

namespace _03._Film_Premiere
{
	class Program
	{
		static void Main(string[] args)
		{
			//•	Първи ред -прожекция - текст с възможности"John Wick", "Star Wars" или "Jumanji"
			//•	Втори ред -пакет за филм -текст  с възможности "Drink", "Popcorn" или "Menu"
			//•	Трети ред -брой билети - цяло число в интервала[1… 30]
			string filmName = Console.ReadLine();
			string foodForFilm = Console.ReadLine();
			int countTicket = int.Parse(Console.ReadLine());
			double totoalSum = 0;
			if (filmName== "John Wick")
			{
				if (foodForFilm== "Drink")
				{
					totoalSum = 12 * countTicket;
				}
				else if (foodForFilm == "Popcorn")
				{
					totoalSum = 15 * countTicket;
				}
				else
				{
					totoalSum = 19 * countTicket;
				}
			}if (filmName== "Star Wars")
			{
				if (foodForFilm== "Drink")
				{
					totoalSum = 18 * countTicket;
				}
				else if (foodForFilm == "Popcorn")
				{
					totoalSum = 25 * countTicket;
				}
				else
				{
					totoalSum = 30 * countTicket;
				}
			}
			if (filmName== "Jumanji")
			{
				if (foodForFilm== "Drink")
				{
					totoalSum = 9 * countTicket;
				}
				else if (foodForFilm == "Popcorn")
				{
					totoalSum = 11 * countTicket;
				}
				else
				{
					totoalSum = 14 * countTicket;
				}
			}
			if (filmName== "Star Wars" && countTicket>=4)
			{
				totoalSum *= 0.7;
			}
			if (filmName == "Jumanji" && countTicket == 2)
			{
				totoalSum*=0.85;
			}
			Console.WriteLine($"Your bill is {totoalSum:f2} leva.");
		}
	}
}
