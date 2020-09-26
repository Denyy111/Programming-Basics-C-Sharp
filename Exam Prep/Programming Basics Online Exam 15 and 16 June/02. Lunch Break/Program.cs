using System;

namespace _02._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double minutesEpizodes = double.Parse(Console.ReadLine());
            double minutesLunch = double.Parse(Console.ReadLine());

            double timeLunch = minutesLunch * 0.125;
            double timeRest = minutesLunch * 0.25;
            double leftTime = minutesLunch - timeLunch - timeRest; // 60

            if (leftTime >= minutesEpizodes)
            {
                leftTime = leftTime - minutesEpizodes;
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(leftTime)} minutes free time.");
            }
            else
            {
                double needMinutes = minutesEpizodes - leftTime;
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(needMinutes)} more minutes.");
            }

        }
    }
}
