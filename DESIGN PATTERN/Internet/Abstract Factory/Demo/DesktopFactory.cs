using CustomerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public interface IMachineFactory
    {
        IProcessor GetRam();
        IHardDisk GetHardDisk();
        IMonitor GetMonitor();
    }

    public class HighBudgetMachine : IMachineFactory
    {
        public IProcessor GetRam() { return new ExpensiveProcessor(); }
        public IHardDisk GetHardDisk() { return new ExpensiveHDD(); }
        public IMonitor GetMonitor() { return new HighResolutionMonitor(); }
    }
    public class LowBudgetMachine : IMachineFactory
    {
        public virtual IProcessor GetRam() { return new CheapProcessor(); }
        public IHardDisk GetHardDisk() { return new CheapHDD(); }
        public IMonitor GetMonitor() { return new LowResolutionMonitor(); }
    }


    //Lets say in future...Ram LowBudgetMachine is decided to upgrade then
    //first make GetRam in LowBudgetMachine Virtual and create new class as follows

    public class AverageBudgetMachine : LowBudgetMachine
    {
        public override IProcessor GetRam()
        {
            return new ExpensiveProcessor();
        }
    }
    public class ComputerShop
    {
        IMachineFactory category;
        public ComputerShop(IMachineFactory _category)
        {
            category = _category;
        }
        public void AssembleMachine()
        {
            IProcessor processor = category.GetRam();
            IHardDisk hdd = category.GetHardDisk();
            IMonitor monitor = category.GetMonitor();
            //use all three and create machine

            processor.PerformOperation();
            hdd.StoreData();
            monitor.DisplayPicture();
        }
    }
}
