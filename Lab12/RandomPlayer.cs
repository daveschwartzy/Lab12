using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer : Player
    {
        public RandomPlayer(string name) :base (name)
        {

        }
        Random rand = new Random();


        public override Roshambo GenerateRoshambo()
        {
            int randomchoice = rand.Next(3);
            Roshambo choice = (Roshambo)randomchoice;
            return choice;
           

        }

    }
}
