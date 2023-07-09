using System;

namespace _08.Cinema_Ticket
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			Да се напише програма която чете ден от седмицата(текст) – въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:
			//Monday Tuesday Wednesday Thursday    Friday Saturday    Sunday
			//12       12		14			14		12	  16		 16
			string dayOfWeek = Console.ReadLine();
			int priceCinema;
			if (dayOfWeek== "Monday" || dayOfWeek == "Tuesday")
			{
				priceCinema = 12;

			}
			else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
			{
				priceCinema = 14;

			}
			else if (dayOfWeek == "Friday" )
			{
				priceCinema = 12;

			}
			else
			{
				priceCinema = 16;
			}
			Console.WriteLine(priceCinema);

		}
	}
}
