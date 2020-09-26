using System;

namespace _09._On_Time_for_the_Exam___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double examHour = double.Parse(Console.ReadLine());
            double examMinutes = double.Parse(Console.ReadLine());
            double arrivalHour = double.Parse(Console.ReadLine());
            double arrivalMinutes = double.Parse(Console.ReadLine());

            double examTime = examHour * 60 + examMinutes;
            double arrivalTime = arrivalHour * 60 + arrivalMinutes;
            double diferent = examTime - arrivalTime;
            double hours = 0;
            double minutes = 0;


            if (diferent <= -1) 
            {
                Console.WriteLine("late");
            }
            else if (diferent >= 0 && diferent <= 30)
            {
                Console.WriteLine("On Time");
            }
            else if (diferent > 30)
            {
                Console.WriteLine("Early");
            }
            if (diferent > 0 && diferent < 60)
            {
                Console.WriteLine($"{diferent} minutes before the start");
            }
            else if (diferent >=60)
            {
                hours = Math.Truncate(diferent / 60);
                minutes = Math.Abs(diferent % 60);

                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes} hours before the start");
                }
            }
            else if (diferent <-60)
            {
                hours = Math.Abs(Math.Truncate(diferent / 60));
                minutes = Math.Abs(diferent % 60);

                if (minutes <10)
                {
                    Console.WriteLine($"{hours}:0{minutes} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes} hours after the start");
                }

            }
          
        }
    }
}
