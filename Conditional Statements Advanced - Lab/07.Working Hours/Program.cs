using System;

namespace _07.Working_Hours
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) -въведени от потребителя и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10 - 18 часа, от понеделник до събота включително
			int hours = int.Parse(Console.ReadLine());
			string dayOfWeek = Console.ReadLine();
			if (dayOfWeek== "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday" )
			{
				
					if (hours >= 10 && hours <= 18)
					{
						Console.WriteLine("Open");
					}
					else
					{
						Console.WriteLine("Closed");
					}
					}
			else
			{
				Console.WriteLine("Closed");
			}
			}
		}
	}

