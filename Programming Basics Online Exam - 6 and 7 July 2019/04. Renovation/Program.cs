using System;

namespace _04._Renovation
{
	class Program
	{
		static void Main(string[] args)
		{
			int hightWall = int.Parse(Console.ReadLine());
			int lenghtWall = int.Parse(Console.ReadLine());
			int persentNoPaint = int.Parse(Console.ReadLine());
			string command;
			double neededPaint = hightWall * lenghtWall * 4;
			neededPaint -= neededPaint * (persentNoPaint / 100.0);
			neededPaint = Math.Ceiling(neededPaint);
			bool isPaint = false;
			while ((command=Console.ReadLine())!= "Tired!")
			{
				int literPaint = int.Parse(command);
				neededPaint -= literPaint;
				if (neededPaint < 0)
				{
					isPaint = true;
					break;
				}

			}
			if (!isPaint)
			{
				Console.WriteLine($"{neededPaint} quadratic m left.");
			}
			else if (neededPaint == 0)
			{
				Console.WriteLine($"All walls are painted! Great job, Pesho!");
			}
			else
			{
				neededPaint = Math.Abs(neededPaint);
				Console.WriteLine($"All walls are painted and you have {neededPaint} l paint left!");
			}

		}
	}
}
