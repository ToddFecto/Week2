using System;

namespace Ex_18
{
    class Program
    {
        static bool calcNumbers()
        {
            while (true)
            {
                Console.Write("\n\nContinue? (y/n): ");                        //Prompts for user input to continue or not
                string moreNumbers = Console.ReadLine();
                moreNumbers = moreNumbers.ToLower();                           //Converts input case to only lower case

                if (moreNumbers == "y" || moreNumbers == "yes")                //Checks the condition to continue measuring rooms or quit
                {
                    return true;
                }
                else if (moreNumbers == "n" || moreNumbers == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exercise 18!\n");                    //Application title

            do
            {
                int i = 0;
                int n = 0;
                int numOut = 0;
                string userIn;
                //int squared = 0;
                //int cubed = 0;

                do
                {
                    Console.Write("\nEnter a number: ");                      //Requests and Accepts user input
                    userIn = Console.ReadLine();
                }
                while (int.TryParse(userIn, out n) == false);

                for (i = 1; i <= n; i++)
                {
                    //squared = i * i;
                    //cubed = i * i * i;
                    numOut = (i + numOut);

                    //Console.Write($"{cubed} ");                                    //Writes the output each iteration on the same line
                }

                Console.Write($"{numOut} ");
            }
            while (calcNumbers());

            Console.WriteLine("\nGoodbye!");
        }
    }
}
