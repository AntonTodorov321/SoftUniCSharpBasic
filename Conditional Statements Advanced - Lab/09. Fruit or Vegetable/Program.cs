using System;

namespace _09._Fruit_or_Vegetable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод или зеленчук.
			string product = Console.ReadLine();

			//•	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и lemon
			if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes")
				Console.WriteLine("fruit");
			else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
				Console.WriteLine("vegetable");
			else
				Console.WriteLine("unknown");
			
			
				
			
			//•	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
			//•	Всички останали са "unknown"
			//Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.

		}
	}
}
