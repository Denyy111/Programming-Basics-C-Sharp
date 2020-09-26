using System;

namespace Inches_and_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            double inches = double.Parse(userInput);

            double centimeters = inches * 2.54;

            Console.WriteLine("{0:F2}", centimeters);
        }
    }
}
