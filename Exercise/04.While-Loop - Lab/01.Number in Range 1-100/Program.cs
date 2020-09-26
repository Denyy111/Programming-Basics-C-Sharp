using System;

namespace _01.Number_in_Range_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;

            counter--;

            Console.WriteLine(counter);

            if (counter-- >= 9)
            {
                Console.WriteLine(counter);

            }


        }
    }
}
