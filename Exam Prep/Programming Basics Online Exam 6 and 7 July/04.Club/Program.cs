using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double expectMoney = double.Parse(Console.ReadLine()); //  500 
            string inputName = Console.ReadLine();
            double totalPrice = 0.00;
            double money = 0.00;
            bool isValide = false;

            while (inputName != "Party!") // 
            {
                int number = int.Parse(Console.ReadLine());
                int price = inputName.Length;
                totalPrice = price * number;

                if (totalPrice % 2 != 0)
                {
                    totalPrice = totalPrice - (totalPrice * 0.25);
                }

                money += totalPrice;

                if (money >= expectMoney)
                {
                    isValide = true;                   
                    break;
                }

                inputName = Console.ReadLine();
            }

            if (isValide)
            {
                Console.WriteLine("Target acquired.");
                Console.WriteLine($"Club income - {money:F2} leva.");
            }
            else
            {
                double diff = expectMoney - money;
                Console.WriteLine($"We need {diff:f2} leva more.");
                Console.WriteLine($"Club income - {money:F2} leva.");
            }            
        }
    }
}
