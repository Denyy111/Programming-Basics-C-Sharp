using System;

namespace _03._Odd_and_Even_Position___Evercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double sumOdd = 0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;

            double sumEven = 0;
            double minEven = 1000000000.0;
            double maxEven = -1000000000.0;
            bool isEven = true;
            bool isOdd = true;


            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    sumEven += number;

                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                    if (number < minEven)
                    {
                        minEven = number;
                    }
                }
                else
                {
                    isEven = false;
                }
                if (number % 2 != 0)
                {
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                    sumOdd += number;
                }
                else
                {
                    isOdd = false;
                }
            }
            if (isOdd==true)
            {
                Console.WriteLine($"OddSum={sumOdd},");
                Console.WriteLine($"OddMin={minOdd},");
                Console.WriteLine($"OddMax={maxOdd},");
            }
            else
            {
                Console.WriteLine($"OddSum={0.00},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            if (isEven==true)
            {
                Console.WriteLine($"EvenSum={sumEven},");
                Console.WriteLine($"EvenMin={minEven},");
                Console.WriteLine($"EvenMax={maxEven},");
            }
            else
            {
                Console.WriteLine($"EvenSum={0.00},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No,");
            }
        }
    }
}





         










            //Console.WriteLine($"OddSum={sumOdd},");

            //if (minOdd == double.MaxValue)
            //{
            //    Console.WriteLine("OddMin= No,");
            //}
            //if (maxOdd == double.MinValue)
            //{
            //    Console.WriteLine("OddMax= No,");
            //}
            //else
            //{
            //    Console.WriteLine($"OddMin={minOdd},");
            //    Console.WriteLine($"OddMax={maxOdd},");
            //}

            //Console.WriteLine($"EvenSum={sumEven},");

            //if (minEven == double.MaxValue)
            //{
            //    Console.WriteLine("EvenMin= No,");
            //}
            //if (maxEven == double.MinValue)
            //{
            //    Console.WriteLine("EvenMax= No,");
            //}
            //else
            //{
            //    Console.WriteLine($"EvenMin={minEven},");
            //    Console.WriteLine($"EvenMax={maxEven},");
            
