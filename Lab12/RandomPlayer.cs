using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer : Player { 

        public string GetRosham()
        {
            return Rosham;
        }
        public override string generateRoshambo()
        {
            Random rand = new Random();
            if (rand.NextDouble() >= .33)
            {
                return Rosham = Roshambo.rock.ToString();
            }
            else if (rand.NextDouble() <= .66)
            {
                return Rosham = Roshambo.paper.ToString();
            }
            else
            {
                return Rosham = Roshambo.scissors.ToString();
            }
        }
        public override string ToString()
        {
            return $"{Rosham}";
        }
    }
}
