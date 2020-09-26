using System;

namespace _04._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int predhodnataSum = 0;
            int diffMax = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int currentSum = firstNumber + secondNumber;

                if (i >= 1)
                {
                    int diff = Math.Abs(currentSum - predhodnataSum);
                    if (diff > diffMax)
                    {
                        diffMax = diff;
                    }
                }
                predhodnataSum = currentSum;
            }
            if (diffMax == 0)
            {
                Console.WriteLine($"Yes, value={predhodnataSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diffMax}");
            }
        }
    }
}
