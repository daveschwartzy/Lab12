using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Roshambo choice;

        public Roshambo Choice
        {
            get { return choice; }
            set { choice = value; }
        }

        public Player(string name)
        {
            this.name = name;
        }

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
            return $"{name}: {choice}\n";
        }
    }
}

