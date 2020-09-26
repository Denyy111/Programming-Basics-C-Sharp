using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int countN = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxValue = int.MinValue;

            for (int i = 0; i < countN; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            sum -= maxValue;

            if (maxValue == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+ sum);
            }
            else
            {
                int diff = sum - maxValue;
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(diff));
            }         
        }
    }
}
