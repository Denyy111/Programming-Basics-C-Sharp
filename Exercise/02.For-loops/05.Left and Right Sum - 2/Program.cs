using System;

namespace _05.Left_and_Right_Sum___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRifht = 0;

            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sumLeft += current;
            }
            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumRifht += currentNumber;
            }
            if (sumRifht == sumLeft)
            {
                Console.WriteLine("Yes, sum = " + sumLeft);
            }
            else
            {
                int diff = sumLeft - sumRifht;
                Console.WriteLine("No, diff = " + Math.Abs(diff));
            }
        }
    }
}
