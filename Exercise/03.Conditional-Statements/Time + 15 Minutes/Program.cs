using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingHour = int.Parse(Console.ReadLine());
            int startingMinutes = int.Parse(Console.ReadLine());

            int totalMinutes = startingHour * 60 + startingMinutes;   // общо всичко в минути

            int minutesPlus15 = totalMinutes + 15;

            int currentHours = minutesPlus15 / 60;      // вече промнените часове
            int currentMinutes = minutesPlus15 % 60;

            if (currentHours == 24)
            {
                currentHours -= 24;
            }

            if (currentMinutes < 10)
            {
                Console.WriteLine($"{currentHours}:0{currentMinutes}");
            }
            else
            {
                Console.WriteLine($"{currentHours}:{currentMinutes}");
            }
        }
    }
}
