using System;

namespace _02._Cinema___excercice
{
    class Program
    {
        static void Main(string[] args)
        {
            string projects = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            if (projects.ToLower() == "premiere")
            {
                totalPrice = rows * columns * 12.00;               
            }
            else if (projects.ToLower() == "normal")
            {
                totalPrice = rows * columns * 7.50;               
            }
            else if (projects.ToLower() == "discount")
            {
                totalPrice = rows * columns * 5.00;               
            }

            Console.WriteLine("{0:f2} leva", totalPrice);
        }
    }
}
