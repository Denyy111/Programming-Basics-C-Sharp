using System;

namespace _05.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNuumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int minValue = int.MaxValue;


            while (counter < countNuumber)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < minValue)
                {
                    minValue = number;
                }
                
               counter++;
            }
            Console.WriteLine(minValue);
        }
    }
}
