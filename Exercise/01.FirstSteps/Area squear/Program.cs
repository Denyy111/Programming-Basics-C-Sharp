using System;

namespace Area_squear
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideLenght = int.Parse(Console.ReadLine());
            int area = sideLenght * sideLenght;

            Console.WriteLine(area);

        }
    }
}