using System;

namespace _16._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

           

            if (input == "mm")      
            {
                number /= 1000;                     // number = number / 1000
            }

            else if (input == "cm")   // превръщаме входната мерна единица в МЕТРИ
            {
                number /= 100;
            }
             if (output == "mm")    // превръщаме метрите в изходната мерна единица
            {
                number *= 1000;
            }
            else if (output == "cm")
            {
                number *= 100;
            }
            Console.WriteLine($"{number:F3}"); 
            //Console.WriteLine("{0:F3}" , number);  
        }
    }
}
