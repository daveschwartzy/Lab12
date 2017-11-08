using System;
using System.Collections;
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
            
            List<Player> opponents = new List<Player>();
            opponents.Add(new RandomPlayer("Ran Dumb"));
            opponents.Add(new DwayneJohnson("Dwayne Johnson"));

            Console.WriteLine("~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~");
            Console.WriteLine("Welcome to the Rock Paper Scissors Simulator");
            Console.WriteLine("~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~\n");

            string name = HumanPlayer.GetName("Please enter your name: ");
            HumanPlayer human = new HumanPlayer(name);


            bool again = true;
            while(again)
            {
                int choose = Validator.ChooseOpponent($"Hi {human.Name}! Please select your opponent.\nChoose 1 for Ran Dumb or 2 for Dwayne Johnson.\n");
                Roshambo choice = human.GenerateRoshambo();
                human.Choice = choice;

                if (opponents[choose] is RandomPlayer)
                {
                    Roshambo opponentChoice = ((RandomPlayer)opponents[choose]).GenerateRoshambo();
                    (opponents[choose]).Choice = opponentChoice;
                    string result = Validator.RoshamResults(human, opponents[choose], human.Choice, (opponents[choose]).Choice);
                    Console.WriteLine(human.ToString() + opponents[choose].ToString() + result);
                }
                else
                {
                    Roshambo opponentChoice = ((DwayneJohnson)opponents[choose]).GenerateRoshambo();
                    (opponents[choose]).Choice = opponentChoice;
                    string result = Validator.RoshamResults(human, opponents[choose], human.Choice, (opponents[choose]).Choice);
                    Console.WriteLine(human.ToString() + opponents[choose].ToString() + result);
                }
                Console.WriteLine($"You won {Validator.win} time(s) and lost {Validator.lose} time(s).\n");
                again = Validator.DoAgain("Would you like to play again? (Y or N)\n");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
