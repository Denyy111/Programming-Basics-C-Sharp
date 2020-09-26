using System;

namespace _01._Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int epizods = int.Parse(Console.ReadLine());
            double minutesEpizode = double.Parse(Console.ReadLine());

            double minutesReclama = minutesEpizode * 0.20;
            double allEpizod = minutesEpizode + minutesReclama;
            double specialEpizodes = seasons * 10;

            double time = allEpizod * seasons * epizods + specialEpizodes;

            Console.WriteLine($"Total time needed to watch the {nameFilm} series is {Math.Floor(time)} minutes.");

        }
    }
}
