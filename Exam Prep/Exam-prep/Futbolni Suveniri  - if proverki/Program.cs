using System;

namespace Futbolni_Suveniri____if_proverki
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCountry = Console.ReadLine();
            string souvenir = Console.ReadLine();
            double countSouvenir = double.Parse(Console.ReadLine());
            double price = 0.0;

          
            if (nameOfCountry == "Argentina")
            {
                if (souvenir == "flags")
                {
                    price = countSouvenir * 3.25;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir}  of {nameOfCountry} for {price:F2}lv.");
                }
                else if (souvenir == "caps")
                {
                    price = countSouvenir * 7.20;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2}lv.");
                }
                else if (souvenir == "posters")
                {
                    price = countSouvenir * 5.10;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2}lv.");
                }
                else if (souvenir == "stickers")
                {
                    price = countSouvenir * 1.25;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2}lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (nameOfCountry == "Brazil")
            {
                if (souvenir == "flags")
                {
                    price = countSouvenir * 4.20;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "caps")
                {
                    price = countSouvenir * 8.50;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "posters")
                {
                    price = countSouvenir * 5.35;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "stickers")
                {
                    price = countSouvenir * 1.20;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (nameOfCountry == "Croatia")
            {
                if (souvenir == "flags")
                {
                    price = countSouvenir * 2.75;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "caps")
                {
                    price = countSouvenir * 6.90;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "posters")
                {
                    price = countSouvenir * 4.95;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "stickers")
                {
                    price = countSouvenir * 1.10;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (nameOfCountry == "Denmark")
            {
                if (souvenir == "flags")
                {
                    price = countSouvenir * 3.10;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "caps")
                {
                    price = countSouvenir * 6.50;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "posters")
                {
                    price = countSouvenir * 4.80;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                }
                else if (souvenir == "stickers")
                {
                    price = countSouvenir * 0.90;
                    Console.WriteLine($"Pepi bought {countSouvenir} {souvenir} of {nameOfCountry} for {price:F2} lv.");
                    
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }           
                            
        }
        
    } 
   
}
