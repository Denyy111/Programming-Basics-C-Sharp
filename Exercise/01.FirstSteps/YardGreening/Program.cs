using System;

namespace YardGreening
{
    class Program 
    {
        static void Main(string[] args)
        {
            double squareМeters = double.Parse(Console.ReadLine());
            double sum = squareМeters * 7.61;
            double discount = 0.18 * sum;
            double finalPrice = sum - discount;


            Console.WriteLine("The final price is: {0:F2} lv." , finalPrice);
            Console.WriteLine("The discount is: {0:F2} lv." , discount);

        }
    }
}
  