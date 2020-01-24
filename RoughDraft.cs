/*
using System;

namespace Lab_Four_Powers_Table
{
    class RoughDraft
    {
        static void Main2(string[] args)
        {

            bool resume = true;
            while (resume)
            {
                int userInput = int.Parse(GetUserInput("Enter the value you would like the table to go to."));

                SquareTo(userInput);

                Console.WriteLine();

                CubeTo(userInput);

                Console.WriteLine();

                char userKey = Console.ReadLine().ToUpper()[0];

                resume = AskToContinue(userKey);

            }


        }


        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();
            return value;

        }

        static void SquareTo(int max)
        {
            Console.Write("Squared: ");
            for (int i = 1; i < max + 1; i++)
            {
                int squared = (i * i);

                Console.Write($" |{squared}| ");

            };

        }
        static void CubeTo(int max)
        {
            Console.Write("Cubed: ");
            for (int i = 1; i < max + 1; i++)
            {

                int cubed = (i * i * i);

                Console.Write($" |{cubed}| ");
            }
        }
        static bool AskToContinue(char userKey)
        {

            Console.WriteLine("Would you like to go again? (Y/N)");

            
            if (userKey == 'Y')
            {
                return true;
            }
            else if (userKey == 'N')
            {
                return false;
            }
            else
            {
                Console.WriteLine("Not a valid input.");
                return false;
            }


        }
    }

}
*/