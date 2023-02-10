using System;

namespace Ex_19
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
            Console.WriteLine("Welcome to Exercise 19!\n");

            do
            {
                //double length = 0;
                //double width = 0;
                int i = 0;
                int n = 0;
                int num1 = 0;
                int num2 = 0;
                int numLower = 0;
                int numUpper = 0;
                int numOut = 0;
                string userIn;

                do
                {
                    Console.Write("\nEnter a number: ");                      //Requests and Accepts user input
                    userIn = Console.ReadLine();
                    //num1 = n;
                }
                while (int.TryParse(userIn, out n) == false);
                    num1 = n;
                do
                {
                    Console.Write("\nEnter another number: ");                      //Requests and Accepts user input
                    userIn = Console.ReadLine();
                    //num2 = n;
                }
                while (int.TryParse(userIn, out n) == false);
                    num2 = n;

                if (num1 < num2)
                {
                    numLower = num1;
                    numUpper = num2;
                }
                else
                {
                    numLower = num2;
                    numUpper = num1;
                }

                for (i =  numLower; i <= numUpper; i++)
                {
                    //squared = i * i;
                    //cubed = i * i * i;
                    numOut = i + numOut;

                    //Console.Write($"{cubed} ");                                    //Writes the output each iteration on the same line
                }

                Console.Write($"The sum of all the numbers from { numLower} to { numUpper} is {numOut}.");
            }while (calcNumbers());     //<<<<Like the keepGoing() method

            Console.WriteLine("\nGoodbye!");
        }
    }
}
