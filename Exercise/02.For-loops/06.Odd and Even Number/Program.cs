﻿using System;

namespace _06.Odd_and_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            if (evenSum == oddSum)
            {               
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                int diff = evenSum - oddSum;
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(diff));
            }
        }
    }
}
