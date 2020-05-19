using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Penny : Coin
    {
        //constructor
        public Penny(string name, double value)
        {
            name = "Penny";
            value = 0.01;

        }
    }
}
