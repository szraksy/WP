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

            string shw = string.Empty;
            shw = "There are 2 more new Announcements!";
            MessageBox.Show(shw);
        }

        private void ColorChange_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.Size = new Size((int)random.Next(100, 400), (int)random.Next(100, 400));
        }

        private void scrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            button1.BackColor = Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            button1.BackColor = SystemColors.Control;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
