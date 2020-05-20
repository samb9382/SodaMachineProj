using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Quarter : Coin
    {
        public string name;
        public double value;
        //constructor
        public Quarter()
        {
            name = "Quarter";
            value = 0.25;
        }
    }
}
