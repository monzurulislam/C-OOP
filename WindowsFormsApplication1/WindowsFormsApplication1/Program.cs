using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Rectangle
    {
        Double _length;
        Double _width;

        public void Acceptdetails(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double GetArea()
        {
            var result = _length * _width;
            return result;
        }

        public void display()
        {
            /* Console.WriteLine("Length is: {0}", _length);
             Console.WriteLine("Width is: {0}", _width);
             Console.WriteLine("Area is: {0}", GetArea());
             Console.ReadLine();*/
            MessageBox.Show(string.Format("Area is: {0} ", GetArea()));
        }

        internal void display(DevExpress.XtraEditors.LabelControl labelControlValue)
        {
            labelControlValue.Text = GetArea().ToString();
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
            Application.Run(new XtraForm1());
        }
    }
}
