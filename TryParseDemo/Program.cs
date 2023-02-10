using System;

namespace TryParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine(sum);

            string name = "Fred";
            string lastname = "Johnson";
            string fullname = name + " " + lastname;
            Console.WriteLine(fullname);

            string numword = "40";
            int n = 50;
            //int newsum = numword + n;    This doesn't work. "40" is a string. not a number
            // To add thse, we need to convert "40" string to 40 integer.
            // Different ways to convert, including something called "casting".
            // int newsum = (int)numword + n;
            // We have to use one of the Parse functions
            int realnum = int.Parse(numword);
            int newsum = realnum + n;
            Console.WriteLine(newsum);

            Console.WriteLine();
            Console.WriteLine("Let's try the TryParse");

            string numword2 = "35";
            int realnum2;
            int.TryParse(numword2, out realnum2);
            int newsum2 = realnum2 + 30;
            Console.WriteLine(newsum2);

        }
    }
}
