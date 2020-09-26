using System;

namespace _04._Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); 
            int nMaches = int.Parse(Console.ReadLine());

            int sumpoints = 0;
            int sumDiff = 0;
            int count = 1;
            int sumGoalsIn = 0;
            int sumGoalsTo = 0;                   
      
            while (count <= nMaches)

            {
                int points = 0;
                int goalsTo = int.Parse(Console.ReadLine()); // 4
                int goalsIn = int.Parse(Console.ReadLine()); // 2

                count++;            

                if (goalsTo > goalsIn)
                {
                    points =+3;
                }
                else if (goalsTo == goalsIn)
                {
                    points =+1;
                }

                sumpoints += points;
                int diff = goalsTo - goalsIn;
                sumDiff += diff;
                sumGoalsIn += goalsIn;
                sumGoalsTo += goalsTo;         
            }

            if (sumGoalsTo >= sumGoalsIn)
            {
                Console.WriteLine($"{name} has finished the group phase with {sumpoints} points.");
                Console.WriteLine($"Goal difference: {sumDiff}.");
            }
            else
            {
                Console.WriteLine($"{name} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {sumDiff}.");
            }
            
        }
      
    }
}
