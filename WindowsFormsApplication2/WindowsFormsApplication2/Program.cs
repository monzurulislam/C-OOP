using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Conversion
    {
        double d;
        int i;

        public void SetValue(double _d)
        {
            d = _d;
        }

        public void display(double toDouble)
        {
            d = toDouble;
            i = (int) d;
            MessageBox.Show(String.Format("Double to interger: {0}", i));
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
