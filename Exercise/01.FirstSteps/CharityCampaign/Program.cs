using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfDay = double.Parse(Console.ReadLine());
            double numOfPeople = double.Parse(Console.ReadLine());
            double numOfCakes = double.Parse(Console.ReadLine());
            double numOfGofrets = double.Parse(Console.ReadLine());
            double numOfPanCakes = double.Parse(Console.ReadLine());

            double sumOfCakes = numOfCakes * 45;
            double sumOfGofrets = numOfGofrets * 5.80;  
            double sumOfPancakes = numOfPanCakes * 3.20;
   
            double moneyForProduct = (sumOfCakes + sumOfGofrets + sumOfPancakes) * numOfPeople;
            double sumOfAllCompany = moneyForProduct * numOfDay;
            double sumOfAfterDays = 0.875 * sumOfAllCompany;
            Console.WriteLine("{0:F2}" , sumOfAfterDays);

        }
    }
}
