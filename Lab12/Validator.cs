using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Validator
    {
        public static int win = 0;
        public static int lose = 0;
        public static bool DoAgain(string prompt)
        {
            bool repeat = false;
            bool valid = false;
            while (!valid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().Trim().ToUpper();
                if (input == "Y")
                {
                    valid = true;
                    repeat = true;
                }
                else if (input == "N")
                {
                    valid = true;
                    repeat = false;
                }
                else
                {
                    Console.Write("\nInvalid entry. Please try again.\n");
                    valid = false;
                }
            }
            return repeat;
        }

        public static Roshambo ValidateChoice(string prompt)
        {
            Roshambo choice = Roshambo.scissors;
            bool valid = false;
            while (!valid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().Trim().ToUpper();

                if (input == "R")
                {
                    choice = Roshambo.rock;
                    valid = true;
                }
                else if (input == "P")
                {
                    choice = Roshambo.paper;
                    valid = true;
                }
                else if (input == "S")
                {
                    choice = Roshambo.scissors;
                    valid = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please try again.\n");
                    valid = false;
                }
            }
            return choice;

        }
        public static int ChooseOpponent(string prompt)
        {
            int opponent = 0;
            bool valid = false;
            while (!valid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (input == "1")
                {
                    opponent = 0;
                    valid = true;
                }
                else if (input == "2")
                {
                    opponent = 1;
                    valid = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid entry. Please try again.\n");
                    valid = false;
                }
            }
            return opponent;
        }
        public static string RoshamResults(Player human, Player opponent, Roshambo choice, Roshambo opponentChoice)
        {
            
            string result = "";
            if (choice == Roshambo.paper)
            {
                if (opponentChoice == Roshambo.paper)
                {
                    result = "Draw!";
                }
                else if (opponentChoice == Roshambo.rock)
                {
                    win++;
                    result = $"You win!";
                }
                else
                {
                    lose++;
                    result = $"{opponent.Name} wins!";
                }
            }
            else if (choice == Roshambo.rock)
            {
                if (opponentChoice == Roshambo.rock)
                {
                    result = "Draw!";
                }
                else if (opponentChoice == Roshambo.scissors)
                {
                    win++;
                    result = $"You win!";
                }
                else
                {
                    lose++;
                    result = $"{opponent.Name} wins!";
                }
            }
            else
            {
                if (opponentChoice == Roshambo.paper)
                {
                    win++;
                    result = $"You win!";
                }
                else if (opponentChoice == Roshambo.rock)
                {
                    lose++;
                    result = $"{opponent.Name} wins!";
                }
                else
                {
                    result = "Draw!";
                }
            }
            return result;
        }
    }
}
