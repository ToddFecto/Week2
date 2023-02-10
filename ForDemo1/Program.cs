using System;

namespace ForDemo1
{
    class Program
    {
        static void Main(string[] args)
        {


            int y = 0;
            for (int x = 0; x < 10; x++)
            {
                y = x;
                Console.WriteLine("Next iteration");
                Console.WriteLine(x);
            }

            Console.WriteLine(y);
            Console.WriteLine("All done!");
        }
    }
}
