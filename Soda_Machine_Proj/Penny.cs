using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Penny : Coin
    {
        public string name;
        public double value;
        //constructor
        public Penny()
        {
            name = "Penny";
            value = 0.01;

        }
    }
}
