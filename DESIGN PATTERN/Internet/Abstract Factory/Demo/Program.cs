using CustomerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{

    class Program
    {
        static void Main(string[] args)
        {
            //Client Code
            IMachineFactory factory = new AverageBudgetMachine();// Or new LowBudgetMachine();
            ComputerShop shop = new ComputerShop(factory);
            shop.AssembleMachine();            
        }
    }
}
