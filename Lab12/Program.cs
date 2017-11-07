using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int loss = 0;
            bool repeat = true;
            while (repeat) { 
            HumanPlayer human = new HumanPlayer();
            RandomPlayer random = new RandomPlayer();
            DwayneJohnson dwayne = new DwayneJohnson();
            

            Console.WriteLine("~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
            Console.WriteLine("Rock, Paper, Scissors Simulator");
            Console.WriteLine("~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            human.Name = input;
            
            Console.WriteLine($"Okay {human.GetName()}, would you like to play against 1. The Rock or 2. Owen Wilson? (Enter 1 or 2)");
            string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    Console.WriteLine($"Okay, {human.GetName()}, Rock, Paper, or Scissors? (R / P / S)");
                    string input3 = Console.ReadLine().Trim().ToUpper();
                    human.SetChoice(input3);
                    human.generateRoshambo();
                    dwayne.generateRoshambo();
                    Console.WriteLine($"{human.GetName()}: {human.GetChoice()}");
                    Console.WriteLine($"The Rock: {dwayne.GetRosham()}");

                    if (human.GetChoice() == "rock")
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (human.GetChoice() == "paper")
                    {
                        Console.WriteLine("Congratulations! You win!");
                        wins++;
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                        loss++;
                    }
                }
                else if (input2 == "2")
                {
                    Console.WriteLine($"Okay, {human.GetName()}, Rock, Paper, or Scissors? (R / P / S)");
                    string input4 = Console.ReadLine();
                    human.SetChoice(input4);
                    human.generateRoshambo();
                    random.generateRoshambo();
                    Console.WriteLine($"{human.GetName()}: {human.GetChoice()}");
                    Console.WriteLine($"Owen Wilson: {random.GetRosham()}");

                    if (human.GetChoice() == random.GetRosham())
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (human.GetChoice() == "rock" && random.GetRosham() == "scissors")
                    {
                        Console.WriteLine("Congratulations! You win!");
                        wins++;
                    }
                    else if (human.GetChoice() == "scissors" && random.GetRosham() == "paper")
                    {
                        Console.WriteLine("Congratulations! You win!");
                        wins++;
                    }
                    else if (human.GetChoice() == "paper" && random.GetRosham() == "rock")
                    {
                        Console.WriteLine("Congratulations! You win!");
                        wins++;
                    }
                    else if (human.GetChoice() == "paper" && random.GetRosham() == "scissors")
                    {
                        Console.WriteLine("You lose!");
                        loss++;
                    }
                    else if (human.GetChoice() == "rock" && random.GetRosham() == "paper")
                    {
                        Console.WriteLine("You lose!");
                        loss++;
                    }
                    else if (human.GetChoice() == "scissors" && random.GetRosham() == "rock")
                    {
                        Console.WriteLine("You lose!");
                        loss++;
                    }
                } repeat = Validator.DoAgain("Would you like to play again? (Y or N) ");
                Console.WriteLine($"You won {wins} time(s) and lost {loss} time(s).");
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
