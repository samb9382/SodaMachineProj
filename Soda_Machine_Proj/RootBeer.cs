using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class RootBeer : Can
    {
        public string name;
        public double cost;
        //constructor
        public RootBeer()
        {
            name = "RootBeer";
            cost = 0.60;
        }
    }
}
