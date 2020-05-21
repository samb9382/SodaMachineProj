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
        public double runningTotal;

        //constructor
        public UserInterface()
        {
            runningTotal = 0;
        }

        public void DepositCoin(double coin) //using a double instead of a string
        {
            Console.WriteLine("Please Deposit your money");
            Console.WriteLine("Enter: 1 for a Penny, 5 for a nickle, 10 for a dime, or 25 for a Quarter");
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


        public void DisplayDrinkSelection()
        {

            Console.WriteLine("We have three sodas in stock:");
            Console.WriteLine("R -- RootBeer");
            Console.WriteLine("O --OrangeSoda");
            Console.WriteLine("C -- Cola");
            Console.WriteLine("Select a Soda: C for COLA, R for ROOTBEER, O for ORANGESODA");
            ChooseDrink(Convert.ToChar(Console.ReadLine().ToUpper()));

        }

        public void ChooseDrink(char sodaChoice)
        {
            bool sodaChoiceSelection = false;
            while (!sodaChoiceSelection)
            {
                switch (sodaChoice)
                {
                    case 'C':
                        Console.WriteLine("You have selected a COLA");
                        sodaChoiceSelection = true;
                        ReturnChange();
                        break;
                    case 'R':
                        Console.WriteLine("You have selected a ROOTBEER");
                        sodaChoiceSelection = true;
                        ReturnChange();
                        break;
                    case 'O':
                        Console.WriteLine("You have selected a ORANGESODA");
                        sodaChoiceSelection = true;
                        ReturnChange();
                        break;
                    default:
                        Console.WriteLine("Not a valid selection. Re-enter your selection");
                        sodaChoice = Convert.ToChar(Console.ReadLine().ToUpper());
                        sodaChoiceSelection = false;
                        break;

                }
            }
        }

        public void ReturnChange()
        {
            if (runningTotal > costOfDrink)
                Console.WriteLine("Your change is $", runningTotal - costOfDrink);
        }

        public bool checkTotal()
        {
            if (runningTotal >= costOfDrink)
            {
                return true; //have sufficient cash
            }
            else
            {
                return false;// not enough money
            }
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



        public void RunMachine()
        {
            DisplayDrinkSelection();
            ChooseDrink();
            DisplayPrice();
            
        }
    }
}
