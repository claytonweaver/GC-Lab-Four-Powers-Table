using System;

namespace Lab_Four_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            bool resume = true;
            while (resume)
            {
                int userInput = int.Parse(GetUserInput("Enter the value you would like the table to go to."));

                for (int i = 1; i < userInput + 1; i++)
                {
                    Console.Write($"Number: |{i}|");
                    SquareTo(i);
                    CubeTo(i);
                    Console.WriteLine();
                }
                    Console.WriteLine("Would you like to go again? (Y/N)");
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

        static void SquareTo(int num)
        {
            int squared = (num * num);
            Console.Write($" Squared: |{squared}|");
        }

        static void CubeTo(int num)
        {
            int cubed = (num * num * num);
            Console.Write($" Cubed: |{cubed}|");
        }

        static bool AskToContinue(char userKey)
        {
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


