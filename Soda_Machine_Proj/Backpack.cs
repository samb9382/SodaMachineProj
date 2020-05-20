using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Backpack
    {
        List<Can> cans;
        public Backpack()
        {
            cans = new List<Can>();

        }


       
        public void AddCan(Can can)
        {
            cans.Add(can);
        }

        public void RemoveCan(Can can)
        {
            cans.Remove(can);
        }
    }
}
