﻿using System;

namespace _2ro_reshenie_na_Chetni_stepeni
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i+=2)
            {
                Console.WriteLine(Math.Pow(2 ,1));               
            }
        }
    }
}
