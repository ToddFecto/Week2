using System;

namespace Ex_21
{
    class Program
    {

        static bool GoAgain()
        {
            while (true)
            {
                Console.Write("\n\nContinue? (y/n): ");                        //Prompts for user input to continue or not
                string MoreWords = Console.ReadLine();
                MoreWords = MoreWords.ToLower();                           //Converts input case to only lower case

                if (MoreWords == "y" || MoreWords == "yes")                //Checks the condition to continue measuring rooms or quit
                {
                    return true;
                }
                else if (MoreWords == "n" || MoreWords == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }

        static bool GetWords()
        {
            while (true)
            {
                Console.Write("\n\nEnter another word? (y/n): ");                        //Prompts for user input to continue or not
                string entry = Console.ReadLine();
                entry = entry.ToLower();                           //Converts input case to only lower case

                if (entry == "y" || entry == "yes")                //Checks the condition to continue measuring rooms or quit
                {
                    return true;
                }
                else if (entry == "n" || entry == "no")
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
            Console.WriteLine("Welcome to Exercise 21!\n");

            do
            {
                int i = 0;
                string[] WordsArray = new string[] { };

                //do
                //{
                    Console.Write("Please enter a word: ");
                    string input = Console.ReadLine();
                    WordsArray[i] = input;
                    i++;
                //} while (GetWords());

                for (i = 0; i <= WordsArray.Length; i++)
                    Console.WriteLine($"{WordsArray[i]} ");

            } while (GoAgain());
        }
    }
}
