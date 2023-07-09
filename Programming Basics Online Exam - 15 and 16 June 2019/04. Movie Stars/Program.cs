using System;

namespace _04._Movie_Stars
{
	class Program
	{
		static void Main(string[] args)
		{
			double bujet = double.Parse(Console.ReadLine());
			string nameActor;
			bool noMoreMoney = false;
			while ((nameActor=Console.ReadLine())!= "ACTION")
			{
				int lenghtName = nameActor.Length;
				if (lenghtName<=15)
				{
					double salary = double.Parse(Console.ReadLine());
					bujet -= salary;
				}
				else
				{
					bujet -= bujet * 0.2;
				}
				if (bujet<0)
				{
					noMoreMoney = true;
					bujet = Math.Abs(bujet);
					Console.WriteLine($"We need {bujet:f2} leva for our actors.");
					break;
				}
			}
			if (!noMoreMoney)
			{
				Console.WriteLine($"We are left with {bujet:f2} leva.");
			}
		}
	}
}
