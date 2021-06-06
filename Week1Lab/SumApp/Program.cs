using System;

namespace SumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var a = rand.Next(11);
            var b = rand.Next(11);
            Console.WriteLine($"{a} + {b}");
        }
    }
}
