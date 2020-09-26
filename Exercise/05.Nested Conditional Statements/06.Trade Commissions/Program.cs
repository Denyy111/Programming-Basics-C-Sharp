using System;

namespace _06.Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comissions = 0;
            

            if (town == "Sofia")
            {                
                if (0 <= sales && sales <= 500)
                {
                    comissions= sales * 0.05;
                    Console.WriteLine("{0:F2}", comissions);
                }
                else if (500 < sales && sales <= 1000)
                {
                    comissions = sales * 0.07;
                    Console.WriteLine("{0:F2}", comissions);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comissions = sales * 0.08;
                    Console.WriteLine("{0:F2}", comissions);
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.12;
                    Console.WriteLine(comissions);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            if (town == "Varna")
            {               
                if (0 <= sales && sales <= 500)
                {
                    comissions = sales * 0.045;
                    Console.WriteLine("{0:F2}", comissions);
                }
                else if (500 < sales && sales <= 1000)
                {
                    comissions = sales * 0.075;
                    Console.WriteLine("{0:F2}", comissions);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comissions = sales * 0.10;
                    Console.WriteLine("{0:F2}", comissions);
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.13;
                    Console.WriteLine("{0:F2}", comissions);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
                   if (town == "Plovdiv")
                    {              
                        if (0 <= sales && sales <= 500)
                        {
                    comissions = sales * 0.055;
                            Console.WriteLine("{0:F2}", comissions);
                        }
                        else if (500 < sales && sales <= 1000)
                        {
                    comissions = sales * 0.08;
                            Console.WriteLine("{0:F2}", comissions);
                        }
                        else if (1000 < sales && sales <= 10000)
                        {
                    comissions = sales * 0.12;
                            Console.WriteLine("{0:F2}", comissions);
                        }
                        else if (sales > 10000)
                        {
                    comissions = sales * 0.145;
                            Console.WriteLine("{0:F2}", comissions);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                }
            }
        }
    

    

