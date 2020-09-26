using System;

namespace _05.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0;

            

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day== "Friday")
            {
                if (fruit == "banana")
                {
                    price = count * 2.50;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "apple")
                {
                    price = count * 1.20;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "orange")
                {
                    price = count * 0.85;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "grapefruit")
                {
                    price = count * 1.45;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "kiwi")
                {
                    price = count * 2.70;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "pineapple")
                {
                    price = count * 5.50;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "grapes")
                {
                    price = count * 3.85;
                    Console.WriteLine("{0:F2}", price);
                }
                else
                {
                    Console.WriteLine("error");
                }               
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = count * 2.70;
                    Console.WriteLine("{0:F2}" , price);
                }
                else if (fruit == "apple")
                {
                    price = count * 1.25;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "orange")
                {
                    price = count * 0.90;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "grapefruit")
                {
                    price = count * 1.60;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "kiwi")
                {
                    price = count * 3.00;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "pineapple")
                {
                    price = count * 5.60;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (fruit == "grapes")
                {
                    price = count * 4.20;
                    Console.WriteLine("{0:F2}", price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
