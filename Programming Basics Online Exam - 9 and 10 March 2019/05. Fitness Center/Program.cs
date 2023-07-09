using System;

namespace _05._Fitness_Center
{
	class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			int peopleTrainigBack = 0;
			int peopleTrainigChest = 0;
			int peopleTrainigAbs = 0;
			int peopleTrainigLegs = 0;
			int peopleByingProteinShake = 0;
			int peopleByingProteinBar = 0;
			for (int i = 0; i < peopleCount; i++)
			{
				string activity = Console.ReadLine();
				if (activity == "Back")
				{
					peopleTrainigBack++;
				}
				else if (activity == "Chest")
				{
					peopleTrainigChest++;
				}
				else if (activity == "Legs")
				{
					peopleTrainigLegs++;
				}
				else if (activity == "Abs")
				{
					peopleTrainigAbs++;
				}
				else if (activity == "Protein shake")
				{
					peopleByingProteinShake++;
				}
				else 
				{
					peopleByingProteinBar++;
				}
			}
			Console.WriteLine($"{peopleTrainigBack} - back");
			Console.WriteLine($"{peopleTrainigChest} - chest");
			Console.WriteLine($"{peopleTrainigLegs} - legs");
			Console.WriteLine($"{peopleTrainigAbs} - abs");
			Console.WriteLine($"{peopleByingProteinShake} - protein shake");
			Console.WriteLine($"{peopleByingProteinBar} - protein bar");
			Console.WriteLine($"{(peopleTrainigBack+peopleTrainigChest+peopleTrainigLegs+peopleTrainigAbs)/(double)peopleCount*100:f2}% - work out");
			Console.WriteLine($"{(peopleByingProteinBar+peopleByingProteinShake)/(double)peopleCount*100:f2}% - protein");
		}
	}
}
