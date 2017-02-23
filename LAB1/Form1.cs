using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Lab_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            this.BackColor = System.Drawing.Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
            textBox2.BackColor = Color.Green;
            this.BackColor = System.Drawing.Color.Violet;
            button2.Enabled = false;
            button1.Enabled = true;
            MessageBox.Show("You changed to Custom Still!");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.Gray;
            this.BackColor = System.Drawing.Color.White;
            button2.Enabled = true;
            button1.Enabled = false;
            MessageBox.Show("You changed to Standard Still!");
        }
              
    }
}
