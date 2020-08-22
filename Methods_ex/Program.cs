using System;

namespace Methods_ex
{
    class Program
    {
            //--------------------------Exercise #2---------------------------
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply (int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

            //-------------------------Exercise #1------------------------
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

            Console.WriteLine($"Thanks, {userName}!  Here is your profile.");
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
                   
                        
        }
    }
}
