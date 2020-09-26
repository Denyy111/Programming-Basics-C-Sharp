using System;

namespace _01.Number_from_1_to_10___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
