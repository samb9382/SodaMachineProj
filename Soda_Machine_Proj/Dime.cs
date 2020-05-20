using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Dime : Coin 
    {
        public string name;
        public double value;
        //constructor
        public Dime()
        {
            name = "Dime";
            value = 0.10;
        }
    }
}
