using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : Player
    {
        private string choice;
        private string opponent;

        public override string generateRoshambo()
        {
            if (choice == "R")
            {
                return choice = Roshambo.rock.ToString();
            }
            else if (choice == "P")
            {
                return choice = Roshambo.paper.ToString();
            }
            else if (choice == "S")
            {
                return choice = Roshambo.scissors.ToString();
            }
            else
            {
                Console.Write("I'm sorry, that was not a valid input. Please try again. Rock, Paper, or Scissors? (R / P / S)\n");
                return choice = generateRoshambo();
            }
        }
        public string GetOpponent()
        {
            return opponent;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetChoice()
        {
            return choice;
        }
        public void SetOpponent (string opponent)
        {
            this.opponent = opponent;
        }
        public void SetChoice(string choice)
        {
            this.choice = choice;
        }
        public override string ToString()
        {
            return $"{Name}: {choice}";
        }
    }
}
