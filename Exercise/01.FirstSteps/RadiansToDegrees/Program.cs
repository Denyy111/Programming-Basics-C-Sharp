using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double number = Math.PI;
            double degrees = rad * 180 / number;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
