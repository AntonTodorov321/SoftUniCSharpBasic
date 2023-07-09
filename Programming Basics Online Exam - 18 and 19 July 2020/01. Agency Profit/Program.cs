using System;

namespace _01._Agency_Profit
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.Име на авиокомпанията -текст
			//2.Брой билети за   възрастни – цяло число в диапазона[1…400]
			//3.Брой детски билети – цяло число в диапазона[25…120]
			//4.Нетна цена на билет за възрастен – реално число в диапазона[100.0…1600.0]
			//5.Цената на такса обслужване - реално число в диапазона[10.0…50.0]
			string airline = Console.ReadLine();
			int ticketAdult = int.Parse(Console.ReadLine());
			int ticketChildren = int.Parse(Console.ReadLine());
			double priceForAdultTicket = double.Parse(Console.ReadLine());
			double serviseFee = double.Parse(Console.ReadLine());
			double priceForChildrenTicket =priceForAdultTicket *0.3;
			double totoalSum = ticketAdult * (priceForAdultTicket + serviseFee) + ticketChildren * (priceForChildrenTicket + serviseFee);
			double profit = totoalSum * 0.2;
			Console.WriteLine($"The profit of your agency from {airline} tickets is {profit:f2} lv.");

		}
	}
}
