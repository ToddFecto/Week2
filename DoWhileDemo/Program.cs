using System;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                //Do-while loops run at least ONCE!
                Console.WriteLine("Inside the while loop!");
                Console.WriteLine(x);
                x++;
            }
            while (x < -5);

            Console.WriteLine("All done!");
            Console.WriteLine(x);
        }
    }
}
