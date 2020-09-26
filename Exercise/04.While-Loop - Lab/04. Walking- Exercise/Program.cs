using System;

namespace _04._Walking__Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSteps = Console.ReadLine(); // "4000" -poluchavame go kayo string
            int totalSteps = 0;

            while (inputSteps != "Going home")
            {
                totalSteps += int.Parse(inputSteps);  // parsvame inputsteps kym totalsteps

                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }

                inputSteps = Console.ReadLine();
            }

            if (inputSteps == "Going home")
            {
                int goingHomeSteps = int.Parse(Console.ReadLine());
                totalSteps += goingHomeSteps;
                int diffSteps = 10000 - totalSteps;

                if (diffSteps > 0)
                {
                    Console.WriteLine($"{diffSteps} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
        }
    }
}
