using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class DwayneJohnson : Player
    {
        public string GetRosham()
        {
            return Rosham = Roshambo.rock.ToString();
        }
        public override string generateRoshambo ()
        {
            Random rand = new Random();
            if (rand == rand)
            {
                return Rosham = Roshambo.rock.ToString();
            }
            return Roshambo.rock.ToString();
        }
        public override string ToString()
        {
            return $"{Rosham}";
        }
    }
}
