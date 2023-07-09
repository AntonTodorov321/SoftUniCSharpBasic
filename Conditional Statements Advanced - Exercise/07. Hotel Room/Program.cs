using System;

namespace _07._Hotel_Room
{
	class Program
	{
		static void Main(string[] args)
		{
			//	
			//Предлагат се и следните отстъпки:
			//•	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
			//•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
			//•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
			//•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
			//Вход
			//Входът се чете от конзолата и съдържа точно 2 реда, въведени от потребителя:
			string month = Console.ReadLine();
			int night = int.Parse(Console.ReadLine());
			double apartmentCount = 0;
			double studioCount = 0;
			if (month == "May" || month == "October")
			{
				studioCount = night * 50;
				apartmentCount = night * 65;
			}
			else if (month == "June" || month == "September")
			{
				studioCount = night * 75.2;
				apartmentCount = night * 68.7;
			}
			else
			{
				studioCount = night * 76;
				apartmentCount = night * 77;
			}
			//Предлагат се и следните отстъпки:
			//•	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
			//•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
			//•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
			//•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
			if (night < 14 && (month == "May" || month == "October"))
			{
				studioCount -= (studioCount * 0.05);
			}
			else if (night > 7 && (month == "May" || month == "October"))
			{
				studioCount = studioCount - (studioCount * 0.3);
			}
			else if (night > 14 && (month == "June" || month == "September"))
			{
				studioCount = studioCount - (studioCount * 0.2);
			}
			if (night > 14)
				apartmentCount *= 0.9;

			//Изход
			//Да се отпечатат на конзолата 2 реда:
			Console.WriteLine($"Apartment: {apartmentCount:f2} lv.");
			//•	На първия ред: “Apartment: { цена за целият престой}
			//			lv.”
			//•	На втория ред: “Studio: { цена за целият престой}
			//			lv.“
			Console.WriteLine($"Studio: {studioCount:f2} lv.");
			//Цената за целия престой форматирана с точност до два знака след десетичната запетая.

		}
	}
}
