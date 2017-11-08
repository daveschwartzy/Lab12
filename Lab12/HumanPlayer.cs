using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base (name)
        {

        }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo Choice = Validator.ValidateChoice($"Okay, {Name}, please choose rock, paper, or scissors. (R / P / S)\n");
            return Choice;
        }
        public static string GetName(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
