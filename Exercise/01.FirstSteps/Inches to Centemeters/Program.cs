using System;

namespace Inches_to_Centemeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
          
            double centemeters = inches * 2.54;

            Console.WriteLine("{0:F2}", centemeters);
        }
    }
}
