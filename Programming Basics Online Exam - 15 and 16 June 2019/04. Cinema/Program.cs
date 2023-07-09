using System;

namespace _04._Cinema
{
	class Program
	{
		static void Main(string[] args)
		{
			int roomCapacity = int.Parse(Console.ReadLine());
			string command;
			bool isFull = false;
			int peopleCount = 0;
			int totoalSum = 0;
			while ((command=Console.ReadLine())!= "Movie time!")
			{
				int people = int.Parse(command);
				peopleCount += people;
				if (peopleCount > roomCapacity)
				{
					isFull = true;
					break;
				}
				totoalSum +=people * 5;
				if (people%3==0)
				{
					totoalSum -= 5;
				}

			}
			if (!isFull)
			{
				Console.WriteLine($"There are {roomCapacity-peopleCount} seats left in the cinema.");
				Console.WriteLine($"Cinema income - {totoalSum} lv.");
			}
			else
			{
				Console.WriteLine("The cinema is full.");
				Console.WriteLine($"Cinema income - {totoalSum} lv.");
			}
		}
	}
}
