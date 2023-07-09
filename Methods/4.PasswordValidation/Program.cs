using System;

namespace _4.PasswordValidation
{
	class Program
	{
		static void Main(string[] args)
		{
			string passwod = Console.ReadLine();
			bool isCharecterValid = CharecterValidation(passwod);
			bool isOnlyLetterAndDigit = OnlyLetterAndDigitValidation(passwod);
			bool isAtleastTwoDigit = AtleastTwoDigitValidation(passwod);

			if (!isCharecterValid)
			{
				Console.WriteLine($"Password must be between 6 and 10 characters");
			}
			if (!isOnlyLetterAndDigit)
			{
				Console.WriteLine("Password must consist only of letters and digits");
			}
			if (!isAtleastTwoDigit)
			{
				Console.WriteLine("Password must have at least 2 digits");
			}
			if (isAtleastTwoDigit&&isCharecterValid&&isOnlyLetterAndDigit)
			{
				Console.WriteLine("Password is valid");
			}
		}

		 static bool AtleastTwoDigitValidation(string passwod)
		{
			int counter = 0;
			foreach (char symbol in passwod)
			{
				if (char.IsDigit(symbol))
				{
					counter++;
				}
			}
			return counter >= 2;
		}

		static bool OnlyLetterAndDigitValidation(string passwod)
		{
			foreach (char symbol in passwod)
			{
				if (!char.IsLetterOrDigit(symbol))
				{
					return false;
				}
			}
			return true;
		}

		static bool CharecterValidation(string passwod)
		{
			return passwod.Length >= 6 && passwod.Length <= 10;
		}
	}
}
