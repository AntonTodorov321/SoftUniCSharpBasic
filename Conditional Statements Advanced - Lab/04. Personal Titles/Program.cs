using System;

namespace _04._Personal_Titles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			Да се напише конзолна програма, която прочита възраст(реално число) и пол('m' или 'f'), въведени от потребителя, и отпечатва обръщение измежду следните:
			double age = double.Parse(Console.ReadLine());
			char gender = char.Parse(Console.ReadLine());

		

			if (gender =='m')
			{
				if (age >=16)
				{
					Console.WriteLine("Mr.");
				}
				else
				{
					Console.WriteLine("Master");
				}
			}
			else 
			{
				if (age >= 16)
				{
					Console.WriteLine("Ms.");
				}
				else
				{
					Console.WriteLine("Miss");
				}
			}

			//•	"Ms." – жена(пол 'f') на 16 или повече години
			//•	"Miss" – момиче(пол 'f') под 16 години

		}
	}
}
