using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double liters = volume * 0.001;
            percent = percent / 100;

            double litersTaken = liters * percent;
            double freeSpace = liters - litersTaken;

            Console.WriteLine("{0:F3}", freeSpace);
        }
    }
}
