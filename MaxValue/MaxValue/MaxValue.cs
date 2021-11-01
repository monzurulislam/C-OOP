using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxValue
{
    class MaxValue
    {
        public int FindMax(int a, int b)
        {
            int result;

            if (a > b)
                result = a;
            else
                result = b;

            MessageBox.Show(string.Format("Big number is: {0}", result));
            return result;


        }
    }

}
