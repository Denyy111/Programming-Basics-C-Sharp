using System;

namespace _02._Numbers_from_1_to_N_throuth_3___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
