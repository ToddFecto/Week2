using System;

namespace ReadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            // OLD WAY Console.WriteLine("Welcome " + name);
            Console.WriteLine($"Welcome {name}");
        }
    }
}
