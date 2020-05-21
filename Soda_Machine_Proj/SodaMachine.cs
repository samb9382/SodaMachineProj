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
        //member variables 
       

        List<Can> cans;
        List<Coin> coins;

        //constructor
        public SodaMachine()
        {
            cans = new List<Can>();//list of cans
            AddCans();

            coins = new List<Coin>();//list of coins
            AddCoins();


        }
        public void AddCans()
        {
            for (int i = 0; i < 10; i++ )
            {
                cans.Add(new Cola());
                               
                cans.Add(new RootBeer());
                
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

