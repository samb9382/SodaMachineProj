using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface interface = new UserInterface();
            interface.RunMachine();
            Console.ReadLine();
        }
    }
}
