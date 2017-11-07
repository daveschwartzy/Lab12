using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        private string name;
        private string rosham;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Rosham
        {
            get { return rosham; }
            set { rosham = value; }
        }

        public abstract string generateRoshambo(); 
    }
}
