﻿using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();

            int numOfProjects = int.Parse(Console.ReadLine());
            int hours = numOfProjects * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", architectName, hours, numOfProjects);
        }
    }
}
