using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class SodaMachine
    {
        List<Coin> coins;

        List<Can> cans;

        public SodaMachine() //list of coins in the soda machine
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



        public SodaMachine() //list of sodas in the soda machine
        {
            coins = new List<Coin>();
        }

        public void AddCoin(Coin coin)
        {
            coins.Add(coin);
        }

        public void RemoveCoin(Coin coin)
        {
            coins.Remove(coin);

        }
}
}
