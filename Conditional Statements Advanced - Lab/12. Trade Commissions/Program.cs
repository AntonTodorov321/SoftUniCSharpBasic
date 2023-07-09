using System;

namespace _12._Trade_Commissions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Напишете конзолна програма, която чете име на град(стринг) и обем на продажби(реално число) , въведени от потребителя, и изчислява и извежда размера на търговската комисионна според горната таблица.Резултатът да се изведе форматиран до 2 цифри след десетичната точка. При невалиден град или обем на продажбите(отрицателно число) да се отпечата "error".
			string town = Console.ReadLine();
			double volumeSell = double.Parse(Console.ReadLine());
			double commission = 0;
			//Град    0 ≤ s ≤ 500    500 < s ≤ 1 000     1 000 < s ≤ 10 000    s > 10 000
			//Sofia   5 %                7 %                       8 %             12 %
			//Varna   4.5 %              7.5 %                      10 %            13 %
			//Plovdiv 5.5 %              8 %                     12 %            14.5 %
			if (town == "Sofia")
			{
				if (volumeSell >= 0 && volumeSell <= 500)
					commission = volumeSell * 0.05;
				else if (volumeSell > 500 && volumeSell<=1000)
					commission = volumeSell * 0.07;
				else if (volumeSell >1000 && volumeSell<=10000)
					commission = volumeSell * 0.08;
				else if (volumeSell > 10000)
					commission = volumeSell * 0.12;
				else
					Console.WriteLine("error");
			}
			else if  (town == "Varna")
			{
				if (volumeSell >= 0 && volumeSell <= 500)
					commission = volumeSell * 0.045;
				else if (volumeSell > 500 && volumeSell <= 1000)
					commission = volumeSell * 0.075;
				else if (volumeSell > 1000 && volumeSell <= 10000)
					commission = volumeSell * 0.1;
				else if (volumeSell > 10000)
					commission = volumeSell * 0.13;
				else
					Console.WriteLine("error");
			}
			else if  (town == "Plovdiv")
			{
				if (volumeSell >= 0 && volumeSell <= 500)
					commission = volumeSell * 0.055;
				else if (volumeSell > 500 && volumeSell <= 1000)
					commission = volumeSell * 0.08;
				else if (volumeSell > 1000 && volumeSell <= 10000)
					commission = volumeSell * 0.12;
				else if (volumeSell > 10000)
					commission = volumeSell * 0.145;
				else
					Console.WriteLine("error");
			}
			else
				Console.WriteLine("error");
			if (commission > 0)
				Console.WriteLine($"{commission:f2}");


		}
	}
}
