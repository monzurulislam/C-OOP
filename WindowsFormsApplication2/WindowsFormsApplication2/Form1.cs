﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                Conversion r = new Conversion();
                r.display(Convert.ToDouble(textBoxValue.Text));
            
       
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
