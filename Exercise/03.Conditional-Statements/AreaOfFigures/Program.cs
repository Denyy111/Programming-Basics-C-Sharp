using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side);
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                Console.WriteLine(sideA * sideB);
            }

            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = radius * radius * Math.PI;

                Console.WriteLine(result);
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double result = (side * height) / 2;
                Console.WriteLine("{0:F3}" , result);
            }
            
        }
    }
}
