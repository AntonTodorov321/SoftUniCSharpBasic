using System;

namespace _04._Game_Number_Wars
{
	class Program
	{
		static void Main(string[] args)
		{
			string nameFirstPlayer = Console.ReadLine();
			string nameSecondPlayer = Console.ReadLine();
			int firstPlayerPoints = 0;
			int secondPlayerPoints = 0;
			string command;
			bool isNumberWar = false;
			string namePlayerWin = "";
			int pointsWin = 0;
			while ((command = Console.ReadLine()) != "End of game")
			{
				int fistPlayerCard = int.Parse(command);
				int secondPlayerCard = int.Parse(Console.ReadLine());
				if (fistPlayerCard > secondPlayerCard)
				{
					firstPlayerPoints += fistPlayerCard - secondPlayerCard;
				}
				else if (secondPlayerCard > fistPlayerCard)
				{
					secondPlayerPoints += secondPlayerCard - fistPlayerCard;
				}
				else
				{
					int numWarFistPlayer = int.Parse(Console.ReadLine());
					int numWarSecondPlayer = int.Parse(Console.ReadLine());
					while (numWarFistPlayer==numWarSecondPlayer)
					{
						numWarFistPlayer = int.Parse(Console.ReadLine());
						numWarSecondPlayer = int.Parse(Console.ReadLine());
					}
					if (numWarFistPlayer>numWarSecondPlayer)
					{
						namePlayerWin = nameFirstPlayer;
						pointsWin = firstPlayerPoints;
					}
					else
					{
						namePlayerWin = nameSecondPlayer;
						pointsWin = secondPlayerPoints;
					}
					isNumberWar = true;
					break;
				}

			}
			if (firstPlayerPoints > secondPlayerPoints)
			{
				namePlayerWin = nameFirstPlayer;
				pointsWin = firstPlayerPoints;
			}
			else if(secondPlayerPoints>firstPlayerPoints)
			{
				namePlayerWin = nameSecondPlayer;
				pointsWin = secondPlayerPoints;
			}
			 if (isNumberWar)
			{
				Console.WriteLine($"Number wars!");
				Console.WriteLine($"{namePlayerWin} is winner with {pointsWin} points");
			}
			else
			{
				Console.WriteLine($"{nameFirstPlayer} has {firstPlayerPoints} points");
				Console.WriteLine($"{nameSecondPlayer} has {secondPlayerPoints} points");
			}
		}
	}
}
