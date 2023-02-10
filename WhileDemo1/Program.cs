using System;

namespace WhileDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x = x + 1;
            }
            Console.WriteLine("All done!");
            Console.WriteLine(x);
        }
    }
}
