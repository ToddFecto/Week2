using System;

namespace ConsoleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Welcome to DevBuild!");
            //Console.WriteLine( (5 + 100) * 5 / 2);

            int mynumber = 529;
            Console.WriteLine(mynumber);
            Console.WriteLine(mynumber / 2);
            mynumber = 600;
            Console.WriteLine(mynumber);

            string message = "Hello from \"DevBuild\"!";
            Console.WriteLine(message);

            float pi = 3.1415926F;
            Console.WriteLine(pi);

            double pi2 = 3.1415926;
            Console.WriteLine(pi2);

            decimal balance = 123.56M;
            Console.WriteLine(balance);

            bool isCredit = true;
            Console.WriteLine(isCredit);
        }
    }
}
