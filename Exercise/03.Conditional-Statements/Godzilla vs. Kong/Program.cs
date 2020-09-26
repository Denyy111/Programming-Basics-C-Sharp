using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            int totalTimeInMinutes = startHour * 60 + startMinutes;

           int totalTimePlus15 = totalTimeInMinutes + 15;
            int currentHour = totalTimePlus15 / 60;
            int currentMinutes = totalTimePlus15 % 60;

            if (currentHour == 24)
            {
                currentHour = currentHour - 24;
            }

            if (currentMinutes < 10)
            {
                Console.WriteLine($"{currentHour}:0{ currentMinutes}");
            }

            else
            {
                Console.WriteLine($"{currentHour}:{currentMinutes}");
            }

        }
    }
}
