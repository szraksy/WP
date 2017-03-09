using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("");
            listBox1.Items.Add("** Students information has to be completed till 10.03.2017");
            listBox1.Items.Add("");
            listBox1.Items.Add("** Student's parents information has to be completed by Group teachers");
        }
    }
}
