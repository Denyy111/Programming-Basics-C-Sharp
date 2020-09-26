using System;

namespace Even_Powers_of_2____2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 1;


            for (int i = 0; i <= number; i+=2)
            {           
                Console.WriteLine(current);
                current = current * 4;
            }
        }
    }
}
