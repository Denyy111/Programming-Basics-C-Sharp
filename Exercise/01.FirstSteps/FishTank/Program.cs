﻿using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double liters = volume * 0.001;
            percent = percent / 100;
            double litersToTaken = liters * percent;
            double freeSpace = liters - litersToTaken;


            Console.WriteLine("{0:F3}", freeSpace );

        }
    }
}

