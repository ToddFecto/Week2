using System;

namespace Assessment_1_After
{
    class Program
    {
        static bool keepDrawing()
        {
            while (true)
            {
                Console.Write("\n\nContinue? (y/n): ");                     //Prompts for user input to continue or not
                string moreNumbers = Console.ReadLine();
                moreNumbers = moreNumbers.ToLower();                        //Converts input case to only lower case

                if (moreNumbers == "y" || moreNumbers == "yes")             //Checks the condition to continue drawing or quit
                {
                    return true;
                }
                else if (moreNumbers == "n" || moreNumbers == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");             //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                int i = 0;
                //int h = 0;
                int n = 0;
                string choice;
                bool IsNum = true;
                do
                {
                    Console.Write("Welcome, please choose a shape you would like to draw (1) Rectangle (2) Triangle: ");
                    choice = Console.ReadLine();

                    if (choice == "1" || choice == "2")    //Checks for input of only 1 or 2
                    {
                        IsNum = false;
                        n = int.Parse(choice);  //Converts input from string value to integer to choose drawing type
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter only 1 or 2!");
                        IsNum = true;
                    }
                } while (IsNum);

                if (n == 1)
                {

                    string resp;
                    int width = 0;
                    int height = 0;

                    Console.Write("\nEnter width: ");
                    resp = Console.ReadLine();
                    width = int.Parse(resp);

                    Console.Write("Enter height: ");
                    resp = Console.ReadLine();
                    height = int.Parse(resp);

                        for (i = 1; i <= height; i++)
                        {
                            Console.WriteLine(new String('*', width));
                            //h++;
                        }
                }
                else if (n == 2)
                {
                    //code for Triangle

                    string alignIn;
                    string resp;
                    int height = 0;
                    int a = 0;
                    char ch = '*';
                    int space = 0;
                    char sp = ' ';
                    int aster = 0;

                    do
                    {
                        Console.Write("\nWould you like to right-align (1) or left-align (2) your triangle? ");
                        alignIn = Console.ReadLine();
                    }
                    while (int.TryParse(alignIn, out a) == false);

                    Console.Write("\nEnter height: ");
                    resp = Console.ReadLine();
                    height = int.Parse(resp);

                    for (i = 1; i <= height; i++)
                    {
                        if (a == 1)
                        {
                            //for (space = 1; space < height; space++)
                            for (space = height; space > i; space--)
                            {
                                Console.Write(sp);
                            }
                            for (aster = 1; aster <= i; aster++)
                            {
                                Console.Write(ch);
                            }
                            Console.WriteLine();
                        }
                        else if (a == 2)
                        {
                            Console.WriteLine(new String('*', i));
                        }
                    }
                }
            }
            while (keepDrawing());

            Console.WriteLine("Goodbye!!");
        }
    }
}
