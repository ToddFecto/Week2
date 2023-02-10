using System;

namespace Lab2_1_JeffVersion
{
    class Program
    {

        static bool KeepGoing()
        {
            while (true)
            {
                Console.WriteLine("Would you like to go again? (y/n)");

                string response = Console.ReadLine();
                response = response.ToLower();

                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Calculator");

            double length = 0;
            double width = 0;
            string resp;

            do
            {
                Console.Write("Enter Length: ");
                resp = Console.ReadLine();
                length = double.Parse(resp);

                Console.Write("Enter Width: ");
                resp = Console.ReadLine();
                width = double.Parse(resp);

                double area = length * width;
                Console.WriteLine($"Area: {area}");

                double perim = 2 * length + 2 * width;
                Console.WriteLine($"Perimeter: {perim}");

                if (area <= 250)
                {
                    Console.WriteLine("This is a small room.");
                }
                else if (area < 650)
                {
                    Console.WriteLine("This is a medium-sized room.");
                }
                else
                {
                    Console.WriteLine("This is a large-sized room.");
                }
            }while (KeepGoing());

        }
    }
}
