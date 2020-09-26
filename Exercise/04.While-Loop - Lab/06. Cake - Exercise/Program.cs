using System;

namespace _06._Cake___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenth = int.Parse(Console.ReadLine());  // 10
            int width = int.Parse(Console.ReadLine()); // 10

            int totalPieces = lenth * width;  // 100 парчета

            while (totalPieces > 0)  // 100 > 0
            {
                string input = Console.ReadLine(); // брой парчета  10 

                if (input == "STOP")
                {                   
                    Console.WriteLine($"{totalPieces} pieces are left.");                                        
                    break;                  
                }
                totalPieces -= int.Parse(input); // 100 - 10 
            }
            if (totalPieces <= 0) // 
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
                        
        }
    }
}
