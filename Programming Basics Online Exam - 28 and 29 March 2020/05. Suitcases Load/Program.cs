using System;

namespace _05._Suitcases_Load
{
	class Program
	{
		static void Main(string[] args)
		{
			double capacityTrunk = double.Parse(Console.ReadLine());
			string command;
			bool isFull = false;
			int suitcaseCount = 0;
			while ((command=Console.ReadLine())!="End")
			{
				double volumeSuitcase = double.Parse(command);
				suitcaseCount++;
				if (suitcaseCount%3==0)
				{
					volumeSuitcase += volumeSuitcase * 0.1;
				}
				capacityTrunk -= volumeSuitcase;
				if (capacityTrunk<0)
				{
					suitcaseCount--;
					Console.WriteLine("No more space!");
					isFull = true;
					break;
				}
			}
			if (!isFull)
			{
				Console.WriteLine("Congratulations! All suitcases are loaded!");
			}
			Console.WriteLine($"Statistic: {suitcaseCount} suitcases loaded.");
		}
	}
}
