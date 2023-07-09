using System;

namespace _06._Operations_Between_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int num1 = int.Parse(Console.ReadLine());	
			int num2 = int.Parse(Console.ReadLine());
			char operation = char.Parse(Console.ReadLine());
			double totalSum = 0;
			string evenOrOdd = "";
			if (operation=='+')
				totalSum = num1 + num2;
			else if (operation == '-')
				totalSum = num1 - num2;
			else if (operation == '*')
				totalSum = num1 * num2;
			else if (operation == '/')
				totalSum = num1 / (double)num2;
			else if (operation == '%' && num2!=0)
				totalSum = num1 % num2;
			if (operation== '+' ||operation== '-' ||operation== '*'  )
			{
				if (totalSum%2==0)
				{
					evenOrOdd = "even";
				}
				else
					evenOrOdd = "odd";
			}

			if ((operation == '/' || operation == '%') )
				if (num2==0)
				{
					Console.WriteLine($"Cannot divide {num1} by zero");
				}
				

			if (operation =='/' & num2!=0)
			{
				Console.WriteLine($"{num1} / {num2} = {totalSum:f2}");
			}
			else if (operation == '+' || operation == '-' ||operation == '*' )
			Console.WriteLine($"{num1} {operation} {num2} = {totalSum} - {evenOrOdd}");
			else if (operation=='%' && num2!=0)
				Console.WriteLine($"{num1} {operation} {num2} = {totalSum}");
			//•	Ако операцията е модулно деление:
			//			o   "{N1} % {N2} = {остатък}"
			//•	В случай на деление с 0(нула): 
			//o   "Cannot divide {N1} by zero"
		}
	}
}
