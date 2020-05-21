using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class UserInterface
    {
        //member variables
        public string sodaChoice;
        public double costOfDrink;
        public double runningTotal { get; set; }

        //constructor
        public UserInterface()
        {

        }

        public void DepositCoin(double coin) //using a double instead of a string
        {
            switch (coin) // can take in 1 for penny, 5 for nickle, 10 for dime, 25 for quarter
            {
                case (1):
                    runningTotal += 1;
                    break;
                case (5):
                    runningTotal += 5;
                    break;
                case (10):
                    runningTotal += 10;
                    break;
                case (25):
                    runningTotal += 25;
                    break;
                default:
                    Console.WriteLine("Not a valid entry");
                    break;


            }
            
        }


        public void DisplayOptions()
        {

            Console.WriteLine("We have three sodas in stock:");
            Console.WriteLine("RootBeer");
            Console.WriteLine("OrangeSoda");
            Console.WriteLine("Cola");
        }

        public void ChooseSoda()
        {
            Console.WriteLine("Select a Soda: COLA, ROOTBEER, ORANGESODA");
            sodaChoice = Console.ReadLine();
            sodaChoice = sodaChoice.ToUpper();
            Console.WriteLine("You chose " + sodaChoice);
        }

        public void DisplayPrice()
        {
            switch (sodaChoice)
            {
                case "ROOTBEER":
                    Console.WriteLine("You owe 0.60 cents for ROOTBEER");
                    break;
                case "COLA":
                    Console.WriteLine("You owe 0.35 cents for COLA");
                    break;
                case "ORANGESODA":
                    Console.WriteLine("You owe 0.06 cents for ORANGESODA");
                    break;
                default:
                    Console.WriteLine("Not a valid option try again");
                    ChooseSoda();
                    break;
            }
        }

        public bool checkTotal()
        {
            if (runningTotal >= costOfDrink)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReturnChange()
        {
            if (runningTotal > costOfDrink)
                Console.WriteLine("Your change is $" runningTotal - costOfDrink);
        }

        public void RunMachine()
        {
            DisplayOptions();
            ChooseSoda();
            DisplayPrice();
            
        }
    }
}
