using System;

namespace _04.Max_Number___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int maxValue = int.MinValue;

            while (counter < countNumber)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxValue)
                {
                    maxValue = number;
                }

                counter++;               
            }
            Console.WriteLine(maxValue);
        }
    }
}
