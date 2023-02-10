using System;
namespace ContinueDemo
{
	class Program
	{
		static bool KeepGoing()
		{
			// Version 0.04. (Agile Programming)

			while (true) 
			{

				// Print out message asking if user wants to continue

				Console.WriteLine("Would you like to go again? (y/n)");

				// Ask the user for their input

				string response = Console.ReadLine();
				response = response.ToLower();

				// Check if they typed "y". If so, return true.
				// Otherwise return false.   YES   yes

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
			do
			{
				Console.WriteLine("Welcome to my game!");
				Console.WriteLine("You won!");
			}
			while (KeepGoing());
		}
	}
}
