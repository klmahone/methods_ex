using System;

namespace Methods_ex
{
    class Program
    {
        static void Main(string[] args)
        {

            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles

            Console.WriteLine("Hello! What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awsome color! What is your farorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Excellent! What is your favorite band?");
            var band = Console.ReadLine();

        }
    }
}
