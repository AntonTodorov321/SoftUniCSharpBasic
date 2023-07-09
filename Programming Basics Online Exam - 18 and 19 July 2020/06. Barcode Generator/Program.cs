using System;

namespace _06._Barcode_Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int end = int.Parse(Console.ReadLine());
			double forthStartNum = start%10;
			start /= 10;
			double tirdStartNum = start % 10.0;
			start /= 10;
			double secondStartNum = start % 10.0;
			start /= 10;
			double firstStartNum = start % 10.0;
			double forthEndNum = end%10;
			end /= 10;
			double tirdEndNum = end % 10.0;
			end /= 10;
			double secondEndNum = end % 10.0;
			end /= 10;
			double firstEndNum = end % 10.0;
			for (double firstNum = firstStartNum; firstNum <= firstEndNum; firstNum++)
			{
				for (double secondNum = secondStartNum; secondNum <= secondEndNum; secondNum++)
				{
					for (double tirndNum = tirdStartNum; tirndNum <= tirdEndNum; tirndNum++)
					{
						for (double forthNum = forthStartNum; forthNum <= forthEndNum; forthNum++)
						{
							if (firstNum%2!=0 && secondNum % 2 != 0 && tirndNum % 2 != 0 && forthNum%2!=0)
							{
								Console.Write($"{firstNum}{secondNum}{tirndNum}{forthNum} ");
							}
						}
					}
				}
			}
		}
	}
}
