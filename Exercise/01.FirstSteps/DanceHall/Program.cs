using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hallArea = (L * 100) * (W * 100);
           
            double areaWardrobe = (A * 100) * (A * 100);
           
            double areaBench = hallArea / 10;
            
            double freeSpace = hallArea - areaWardrobe - areaBench;
           
            double dancer = freeSpace / (40 + 7000); 

            Console.WriteLine(Math.Floor(dancer));



            
        }
    }
}


