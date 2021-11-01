using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
           
            int a = Convert.ToInt32(firstNumber.Text);
            int b = Convert.ToInt32(secondNumber.Text);

            var maxValue = new MaxValue();
            var res = maxValue.FindMax(a, b);

            result.Text = Convert.ToString(res);

        }


    }
}
