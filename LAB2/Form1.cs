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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            this.MaximumSize = new Size(300, 300);
            this.MinimumSize = new Size(300, 300);
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
           
            string str = string.Empty;
            foreach (object selectedItem in listBox1.SelectedItems)
            {
              str += "You are working on " +selectedItem.ToString() + Environment.NewLine;
            }

            listBox1.Text = str;
            MessageBox.Show(str);

            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
            this.Close();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
