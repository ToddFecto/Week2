using System;

namespace TryParseDemo2
{
    class Program
    {

        static void Test1()
        {
            int num;
            bool worked = int.TryParse("E", out num);

            if (worked == true)
            {
                Console.WriteLine("Number converted");
                Console.WriteLine($"The value is {num}");

            }
            else
            {
                Console.WriteLine("Sorry, that isn't a number");
            }
        }

        static void Test2()
        {
            int num;
            string resp;
            do
            {
                Console.WriteLine("Enter a number: ");
                resp = Console.ReadLine();
            }
            while (int.TryParse(resp, out num) == false);

            Console.WriteLine($"Number is {num}");
        }

        static void Main(string[] args)
        {
            Test2();
            Test1();
        }
    }
}
