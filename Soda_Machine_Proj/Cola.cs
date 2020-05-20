using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    public class Cola : Can
    {

        public string name;
        public double cost;

        //constructor
        public Cola()
        {
            name = "Cola";
            cost = 0.35;
        }
    }
}
