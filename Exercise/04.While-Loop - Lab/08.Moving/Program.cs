﻿using System;

namespace _08.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalSpace = width * length * height;
            int usedSpace = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                usedSpace += boxes;

                if (usedSpace > totalSpace)
                {
                    int diffSpace = Math.Abs(usedSpace - totalSpace);
                    Console.WriteLine($"No more free space! You need {diffSpace} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                int freeSpace = totalSpace - usedSpace;
               Console.WriteLine("{0} Cubic meters left.", freeSpace);
            }
        }
    }
}
