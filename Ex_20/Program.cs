using System;

namespace Ex_20
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
            Console.WriteLine("Welcome to Exercise 20!\n");

            do
            {
                int numLower = 0;
                int numMiddle = 0;
                int numUpper = 0;

                int numOut = 0;
                string userIn;

                do
                {
                    Console.Write("\nEnter a number: ");                      //Requests and Accepts user input
                    userIn = Console.ReadLine();
                    //num1 = n;
                }
                while (int.TryParse(userIn, out numUpper) == false);

                    numLower = (numUpper - 2);
                    numMiddle = (numUpper - 1);
                    numOut = (numUpper * numMiddle * numLower);

                    Console.Write($"The product of { numUpper}, { numMiddle}, { numLower}, is {numOut}.");
            } while (calcNumbers());

            Console.WriteLine("\nGoodbye!");
        }
    }
}
