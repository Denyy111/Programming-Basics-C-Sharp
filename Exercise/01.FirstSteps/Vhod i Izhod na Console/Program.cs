using System;

namespace Vhod_i_Izhod_na_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            Console.WriteLine(number + 1);

        }
    }
}
