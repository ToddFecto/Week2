using System;

namespace MethodDemo1
{
    class Program
    {

        static void PrintName()
        {
            Console.WriteLine("Hello, my name is Todd");
            int x = 10;
            Console.WriteLine(x);
        }

        static int GetNumber()
        {
            int x = 100;
            x = x / 2;
            return x;
        }

        static string GetName()
        {
            return "Todd";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my program");
            PrintName();

            Console.WriteLine();
            int n = 0;
            Console.WriteLine(n);
            n = GetNumber();
            Console.WriteLine(n);

            Console.WriteLine();
            string name = GetName();
            Console.WriteLine(name);

            Console.WriteLine("All done!");
        }
    }
}
