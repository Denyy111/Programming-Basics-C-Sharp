using System;

namespace _2.HighterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           int firstNumber = int.Parse(Console.ReadLine());
           int secontNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secontNumber)
            {
                Console.WriteLine(firstNumber);
            }

            else
            {
                Console.WriteLine(secontNumber); 
            }
        }
    }
}
