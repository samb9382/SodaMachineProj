using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Nickle : Coin
    {
        //constructor
        public Nickle(string name, double value)
        {
            name = "Nickle";
            this.value = value;
        }
    }
}
