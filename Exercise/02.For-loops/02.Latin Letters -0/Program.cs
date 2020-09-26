using System;

namespace _02.Latin_Letters__0
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNumber = (int)'a';
            int secndNumber = 'z';

            for (int i = firsNumber; i <= secndNumber; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
