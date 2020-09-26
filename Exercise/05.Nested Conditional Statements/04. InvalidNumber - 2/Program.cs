using System;

namespace _04._InvalidNumber___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isValid = (number == 0 || number >= 100 && number <= 200);

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
