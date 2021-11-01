using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public interface IProcessor 
    {
        void PerformOperation();
    }
    public interface IHardDisk { void StoreData(); }
    public interface IMonitor { void DisplayPicture();}

    public class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform quickly");
        }
    }
    public class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform Slowly");
        }
    }

    public class ExpensiveHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take less time to store");
        }
    }
    public class CheapHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take more time to store");
        }
    }

    public class HighResolutionMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Picture quality is Best");
        }
    }
    public class LowResolutionMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Picture quality is Average");
        }
    }
}
