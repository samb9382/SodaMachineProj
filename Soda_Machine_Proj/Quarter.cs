using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Quarter : Coin
    {
        //constructor
        public Quarter(string name, double value)
        {
            name = "Quarter";
            this.value = value;
        }
    }
}
