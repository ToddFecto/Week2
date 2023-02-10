using System;

namespace FunctionPractice
{
    class Program
    {
        static double calcCircle(double radius)
        {
            return 3.1415 * radius * radius;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double area = calcCircle(2.5);
            Console.WriteLine((area));
        }
    }
}
