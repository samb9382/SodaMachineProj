using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Nickle : Coin
    {
        public string name;
        public double value;
        //constructor
        public Nickle()
        {
            name = "Nickle";
            value = 0.05;
        }
    }
}
