using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int eventSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    eventSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            if (oddSum == eventSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + eventSum);
            }
            else
            {
                int diff = eventSum - oddSum;
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(diff));
            }
        }
    }
}
