﻿using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;


            //            if (town == "Sofia")
            //            {
            //                if (productName == "coffee")
            //                {

            //                    Console.WriteLine(quantity * 0.50);
            //                }
            //                else if (productName == "water")
            //                {
            //                    Console.WriteLine(quantity * 0.80);
            //                }
            //                else if (productName == "beer")
            //                {
            //                    Console.WriteLine(quantity * 1.20);
            //                }
            //                else if (productName == "sweets")
            //                {
            //                    Console.WriteLine(quantity * 1.45);
            //                }
            //                else if (productName == "peanuts")
            //                {
            //                    Console.WriteLine(quantity * 1.60);
            //                }
            //            }
            //            else if (town == "Plovdiv")
            //            {
            //                if (productName == "cofee")
            //                {
            //                    Console.WriteLine(quantity * 0.40);
            //                }
            //                else if (productName == "water")
            //                {
            //                    Console.WriteLine(quantity * 0.70);
            //                }
            //                else if (productName == "beer")
            //                {
            //                    Console.WriteLine(quantity * 1.15);
            //                }
            //                else if (productName == "sweets")
            //                {
            //                    Console.WriteLine(quantity * 1.30);
            //                }
            //                else if (productName == "peanuts")
            //                {
            //                    Console.WriteLine(quantity * 1.50);
            //                }
            //            }
            //            else if (town == "Varna")
            //            {

            //                if (productName == "cofee")
            //                {
            //                    Console.WriteLine(quantity * 0.45);
            //                }
            //                else if (productName == "water")
            //                {
            //                    Console.WriteLine(quantity * 0.70);
            //                }
            //                else if (productName == "beer")
            //                {
            //                    Console.WriteLine(quantity * 1.10);
            //                }
            //                else if (productName == "sweets")
            //                {
            //                    Console.WriteLine(quantity * 1.35);
            //                }
            //                else if (productName == "peanuts")
            //                {
            //                    Console.WriteLine(quantity * 1.55);
            //                }
            //            }
            //        }
            //    }
            //}


            if (town == "Sofia")
            {
                if (productName == "coffee")
                {
                    price = quantity * 0.50;
                    Console.WriteLine(price);
                }
                else if (productName == "water")
                {
                    price = quantity * 0.80;
                    Console.WriteLine(price);
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.20;
                    Console.WriteLine(price);
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.45;
                    Console.WriteLine(price);
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.60;
                    Console.WriteLine(price);
                }
            }
            else if (town == "Plovdiv")
            {
                if (productName == "cofee")
                {
                    price = quantity * 0.40;
                    Console.WriteLine(price);
                }
                else if (productName == "water")
                {
                    price = quantity * 0.70;
                    Console.WriteLine(price);
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.15;
                    Console.WriteLine(price);
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.30;
                    Console.WriteLine(price);
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.50;
                    Console.WriteLine(price);
                }
            }
            else if (town == "Varna")
            {
                if (productName == "cofee")
                {
                    price = quantity * 0.45;
                    Console.WriteLine(price);
                }
                else if (productName == "water")
                {
                    price = quantity * 0.70;
                    Console.WriteLine(price);
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.10;
                    Console.WriteLine(price);
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.35;
                    Console.WriteLine(price);
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.55;
                    Console.WriteLine(price);
                }
            }
        }
    }
}
