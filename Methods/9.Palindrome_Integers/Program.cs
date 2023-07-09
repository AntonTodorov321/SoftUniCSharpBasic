using System;

namespace _9.Palindrome_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			while (command!="END")
			{
				Console.WriteLine(PalingromeInteger(command).ToString().ToLower());
				command = Console.ReadLine();
			}
		}

		 static bool PalingromeInteger(string command)
		{
			int num = int.Parse(command);
			int b = 1;
			int counter = 0;
			if (num>=0 && num <=9)
			{
				return true;
			}
			for (int i = 0; i < command.Length/2; i++)
			{
				if (command[i]==command[command.Length-b])

				{
					counter++;
				}
				b++;
			}
			return counter == command.Length / 2;
		}
	}
}
