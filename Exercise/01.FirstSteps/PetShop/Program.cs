using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfDogs = double.Parse(Console.ReadLine());
            double otherPets = double.Parse(Console.ReadLine());
            double food = numOfDogs * 2.50;
            double neighFood = otherPets * 4;
            double total = food + neighFood;

            Console.WriteLine("{0:F2} lv. ", total);

        }
    }
}
