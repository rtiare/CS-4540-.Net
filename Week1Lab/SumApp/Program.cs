using System;

namespace SumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            //create random variables
            var a = rand.Next(11);
            var b = rand.Next(11);
            Console.Write($"{a} + {b} = ");

            //read user input
            var userInput = Console.ReadLine();

            //determine is user input is wrong or correct
            if ((a + b) == int.Parse(userInput))
            {
                Console.WriteLine("Your answer is correct.");
            }
            else {
                Console.WriteLine($"Your answer is incorrect. The correct answer is {a+b}.");
            }
        }
    }
}
