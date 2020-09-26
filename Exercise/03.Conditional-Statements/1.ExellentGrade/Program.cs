using System;

namespace _1.ExellentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            double greade = double.Parse(Console.ReadLine());

            if (greade >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
