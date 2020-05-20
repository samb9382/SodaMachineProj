using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class SodaMachine
    {
        List<Can> cans;


        public SodaMachine()
        {
            cans = new List<Can>();
            AddCans();


        }
        public void AddCans()
        {
            for (int i = 0; i < 10; i++ )
            {
                cans.Add(new Cola());
                if (i < 5)
                {
                    cans.Add(new RootBeer());
                }
                cans.Add(new OrangeSoda());
            }

           

        }
    }






}

