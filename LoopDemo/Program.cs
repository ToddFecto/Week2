using System;

namespace LoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            int height = Int32.Parse(Console.ReadLine());

            // If the height is less than 20, print out  message "Small height".
            // Or, if the height is at least 20 but less than 40, print out "Medium height".
            // Otherwise, print out "Large height".

            if (height < 20)
            {
                Console.WriteLine("Small height");
            }
            else if (height < 40)
            {
                Console.WriteLine("Medium height");
            }
            else
            { 
                Console.WriteLine("Large height"); 
            }
        }
    }
}
