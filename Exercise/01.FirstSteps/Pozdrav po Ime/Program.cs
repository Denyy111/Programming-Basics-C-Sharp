using System;

namespace Pozdrav_po_Ime
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string greeting = "Hello, " + name + "!";

           Console.WriteLine(greeting);
        }
    }
}
