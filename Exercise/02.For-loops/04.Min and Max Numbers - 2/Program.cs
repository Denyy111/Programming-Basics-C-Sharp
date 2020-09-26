using System;

namespace _04.Min_and_Max_Numbers___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine()); // 

                if (number < minNumber)
                {
                    minNumber = number;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
