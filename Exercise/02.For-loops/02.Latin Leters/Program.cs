using System;

namespace _02.Latin_Leters
{
    class Program
    {
        static void Main(string[] args)
        {


            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int startNumber = (int)'a';
            int endNumber = 'z';

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}



