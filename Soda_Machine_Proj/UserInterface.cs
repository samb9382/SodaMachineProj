using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class UserInterface
    {
        public string sodaChoice;

        public UserInterface()
        {
            Console.WriteLine("Welcome");

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

    }
}
