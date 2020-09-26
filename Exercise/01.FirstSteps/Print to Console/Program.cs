using System;

namespace Print_to_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = (Console.ReadLine());
            string lastName = (Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            //Console.WriteLine(firstName + " " + lastName + " " + age + " " +  town);

            Console.WriteLine("first name: {0}, last name: {1}, age: {2}, town: {3}",
               firstName,
               lastName,
               age,
               town);


        }
    }
}
