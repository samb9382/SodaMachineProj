using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Dime : Coin 
    {
        //constructor
        public Dime(string name, double value)
        {
            name = "Dime";
            this.value = value;
        }
    }
}
