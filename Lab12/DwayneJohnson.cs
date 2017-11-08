using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class DwayneJohnson : Player
    {
        public DwayneJohnson(string name)
              : base(name)
        {

        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
