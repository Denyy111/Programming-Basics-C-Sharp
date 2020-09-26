using System;

namespace _01.Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool firstCoundition = y == y1 && (x >= x1 && x <= x2);
            bool secondCondition = y == y1 && (x >= x1 && x <= x2);
            bool thirdCondition = x == x1 && (y >= y1 && y <= y2);
            bool fourthCondition = x == x2 && (y >= y1 && y <= y2);


            bool border = firstCoundition || secondCondition || thirdCondition || fourthCondition;

            if (border)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}