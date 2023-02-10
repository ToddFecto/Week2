using System;

namespace Assessment_1
{
    class Program
    {
        static bool keepDrawing()
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
            do
            {
                int i = 0;
                int h = 0;
                int n = 0;
                string choice;

                do
                {
                    Console.Write("Welcome, please choose a shape you would like to draw (1) Rectangle (2) Triangle: \n\n");
                    choice = Console.ReadLine();
                }
                while (int.TryParse(choice, out n) == false);

                if (n == 1)
                {

                    string resp;
                    double width = 0;
                    double height = 0;

                    Console.Write("Enter width: ");
                    resp = Console.ReadLine();
                    width = double.Parse(resp);

                    Console.Write("Enter height: ");
                    resp = Console.ReadLine();
                    height = double.Parse(resp);

                    for (h = 1; h <= height; h++)
                    {
                        for (i = 1; i <= width; i++ )
                        {
                            Console.Write("*");
                        }
                    }


                }
                else if (n == 2)
                {

                    ///code for Triangle
                    ///

                    string resp;
                    double height = 0;

                    Console.Write("Enter height: ");
                    resp = Console.ReadLine();
                    height = double.Parse(resp);
                }

            }
            while (keepDrawing());

        }
    }
}
