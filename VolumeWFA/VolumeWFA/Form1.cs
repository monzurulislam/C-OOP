using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Box box = new Box();
            box.SetHeight(Convert.ToDouble(textBox2.Text));
            box.setLength(Convert.ToDouble(textBox3.Text));
            box.SetBreadth(Convert.ToDouble(textBox4.Text));

            var asnwer = box.GetVolume();
            
            textBox1.Text = Convert.ToString(asnwer);
            //Application.DoEvents();
            MessageBox.Show(string.Format("Volume of the Box is: {0}", asnwer));
        }
    }
}
