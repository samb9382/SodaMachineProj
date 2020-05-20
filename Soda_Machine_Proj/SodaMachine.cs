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
        List<Coin> coins;


        public SodaMachine()
        {
            cans = new List<Can>();
            AddCans();

            coins = new List<Coin>();
            AddCoins();


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

        public void AddCoins()
        {
            for (int i = 0; i < 50; i++)
            {
                coins.Add(new Penny());
                if (i < 20)
                coins.Add(new Quarter());
                if (i < 10)
                {
                    coins.Add(new Dime());
                }
                if (i < 20)
                {
                    coins.Add(new Nickle());
                }       
            }
        }
    }






}

