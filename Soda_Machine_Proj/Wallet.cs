using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Wallet
    {
        List<Coin> coins;

        public Wallet()
        {
            coins = new List<Coin>();
        }

        public void AddCoin(Coin coin)
        {
            coins.Add(coin);
        }

        public void RemoveCoin(Coin coin)
        {
            coins.Add(coin);
        }
    }
}
