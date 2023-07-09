using System;

namespace _06._Easter_Decoration
{
	class Program
	{
		static void Main(string[] args)
		{
			int clientCount = int.Parse(Console.ReadLine());
			string decoration;
			double totoalSum = 0;
			for (int i = 0; i < clientCount; i++)
			{
				int basketCount = 0;
				int wreathCount = 0;
				int productCount = 0;
				int chocolateBunnyCount = 0;
				while ((decoration=Console.ReadLine())!= "Finish")
				{
					productCount++;
					if (decoration== "basket")
					{
						basketCount++;
					}
					else if (decoration== "wreath")
					{
						wreathCount++;
					}
					else
					{
						chocolateBunnyCount++;
					}
				}
				double sumForClient = basketCount * 1.5 + wreathCount * 3.8 + chocolateBunnyCount * 7;
				if (productCount%2==0)
				{
					sumForClient *= 0.8;
				}
				totoalSum += sumForClient;
				Console.WriteLine($"You purchased {productCount} items for {sumForClient:f2} leva.");
			}
			Console.WriteLine($"Average bill per client is: {totoalSum/clientCount:f2} leva.");
		}
	}
}
