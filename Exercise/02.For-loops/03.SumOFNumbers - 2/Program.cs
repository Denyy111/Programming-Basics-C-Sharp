﻿using System;

namespace _03.SumOFNumbers___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                sum += current;
                                  
            }
            Console.WriteLine(sum);
        }      
    }
}
