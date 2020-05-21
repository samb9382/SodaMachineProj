using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Wallet      
    {

        public double amountofMoney;
        List<Coin> coins;

        public Wallet()
        {
            coins = new List<Coin>();
            AddCoins();
            amountofMoney = 5.00;
        }

        public void AddCoins()
        {
            for (int i = 0; i < 100; i++)
            {
                coins.Add(new Penny());
                if (i < 8)
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

        public void RemoveCoin(Coin coin)
        {
            coins.Remove(coin);
        }
    }
}
