using System;

namespace _05._Left_and_Right_Sum___Vtoro_reshenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                leftSum += currentNumber;
            }

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                rightSum += currentNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                int difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", difference);
            }
        }
    }
}
