﻿using System;

namespace _01._Number_Arange__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || 100 < number)
            {
                Console.WriteLine("Invalid number!");

                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + number);
        }
    }
}

         
