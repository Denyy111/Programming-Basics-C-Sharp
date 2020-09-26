using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drings = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countDrings = int.Parse(Console.ReadLine());
            double price = 0;

            if (drings == "Espresso")
            {
                if (sugar == "Without")
                {
                    price = countDrings * 0.90;
                    price = price - (price * 0.35);
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }
                else if (sugar == "Normal")
                {
                    price = countDrings * 1.00;
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }
                else if (sugar == "Extra")
                {
                    price = countDrings * 1.20;
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }
                if (countDrings > 5)
                {
                    price = price - (price * 0.25);
                }               
            }
            else if (drings == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    price = countDrings * 1.00;
                    price = price - (price * 0.35);
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }
                else if (sugar == "Normal")
                {
                    price = countDrings * 1.20;
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }
                else if (sugar == "Extra")
                {
                    price = countDrings * 1.60;
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }                
            }
            else if (drings == "Tea")
            {
                if (sugar == "Without")
                {
                    price = countDrings * 0.50;
                    price = price - (price * 0.35);
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }
                else if (sugar == "Normal")
                {
                    price = countDrings * 0.60;
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }
                else if (sugar == "Extra")
                {
                    price = countDrings * 0.70;
                    if (price > 15)
                    {
                        price = price - (price * 0.20);
                    }
                }                   
            }
            Console.WriteLine($"You bought {countDrings} cups of {drings} for {(price):F2} lv.");
        }
    }
}