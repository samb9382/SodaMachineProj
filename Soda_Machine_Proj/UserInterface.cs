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

            Console.WriteLine("Please make a drink selection:");
            Console.WriteLine("One For RootBeer");
            Console.WriteLine("Two For OrangeSoda");
            Console.WriteLine("Three For Cola");
        }

        public void ChooseSoda()
        {
            Console.WriteLine("Select a Soda: COLA, ROOTBEER, ORANGESODA");
            sodaChoice = Console.ReadLine();
            sodaChoice = sodaChoice.ToUpper();
            Console.WriteLine("You chose " + sodaChoice);
        }

    }
}
