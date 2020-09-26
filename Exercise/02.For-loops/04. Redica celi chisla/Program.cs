using System;

namespace _04._Redica_celi_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;


            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());  // 20

                if (number > maxValue)
                {
                    maxValue = number;
                }
                if (number < minValue)
                {
                    minValue = number;
                }
            }
            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");
        }
    }
}
