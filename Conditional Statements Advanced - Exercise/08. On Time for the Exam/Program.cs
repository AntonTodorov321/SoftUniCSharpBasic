using System;

namespace _08._On_Time_for_the_Exam
{
	class Program
	{
		static void Main(string[] args)
		{
			//Студент трябва да отиде на изпит в определен час(например в 9:30 часа).Той идва в изпитната зала в даден час на пристигане(например 9:40).Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.Ако е пристигнал по-рано повече от 30 минути, той е подранил.Ако е дошъл след часа на изпита, той е закъснял.Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.
			int hourExam = int.Parse(Console.ReadLine());
			int minitesExam = int.Parse(Console.ReadLine());
			int hourCome = int.Parse(Console.ReadLine());
			int minetsCome = int.Parse(Console.ReadLine());
			hourExam *= 60;
			int sumExam = hourExam + minitesExam;
			hourCome *= 60;
			int sumCome = hourCome + minetsCome;
			int lateTime = sumCome - sumExam;
			int beforeTime = sumExam - sumCome;

			if (sumExam<sumCome)
			{
				Console.WriteLine("Late");
			}
			else if ((sumExam - sumCome) >30)
			{
				Console.WriteLine("Early");
			}
			else 
			{
				Console.WriteLine("On time");
			}
			//Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
			//•	
			if (sumCome-sumExam>=1 && sumCome-sumExam<60)
			{
				Console.WriteLine($"{lateTime} minutes after the start");
			}
			else if (sumCome-sumExam>60)
			{
				int minetsLate = lateTime % 60;
				int hoursLate = lateTime / 60;
				Console.WriteLine($"{hoursLate}: {minetsLate:d2} hours after the start");
			}
			else if (beforeTime>=60)
			{
				int minetsBefore = beforeTime % 60;
				int hoursBefore = beforeTime / 60;
				Console.WriteLine($"{hoursBefore}:{minetsBefore:d2} hours before the start");
			}
			else if (beforeTime>=1)
			{
				Console.WriteLine($"{beforeTime} minutes before the start");
			}
			//“mm minutes after the start” за закъснение под час.
			//•	“hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:03”.


		}
	}
}
