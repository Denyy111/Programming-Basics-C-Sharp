using System;

namespace Cake___02.exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            
            int allPiaces = width * lenght;  // 100
            
            string input = Console.ReadLine(); // 20

            while (input != "STOP")
            {
                int piaces = int.Parse(input);
                allPiaces -= piaces;  

                if (allPiaces <= 0)
                {                
                    Console.WriteLine($"No more cake left! You need {Math.Abs(allPiaces)} pieces more.");
                    break;
                }
               
                input = Console.ReadLine();
            }

            if (input == "STOP")
            {            
                Console.WriteLine($"{allPiaces} pieces are left.");
            }
        }
    }
}
