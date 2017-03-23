using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        public void DrawLinePoint(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            Point point1 = new Point(100, 100);
            Point point2 = new Point(500, 100);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, point1, point2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            //Rectangle
            Pen firca = new Pen(System.Drawing.Color.Red, 5);
            grafiknesne.DrawRectangle(firca, 30, 40, 150, 50);
            //square
            Pen firca1 = new Pen(System.Drawing.Color.Blue, 5);
            grafiknesne.DrawRectangle(firca1, 250, 150, 120, 120);
            //ellipse
            Pen firca2 = new Pen(System.Drawing.Color.Black, 5);
            grafiknesne.DrawEllipse(firca2, 250, 40, 150, 50);
            //circle
            Pen firca3 = new Pen(System.Drawing.Color.Green, 5);
            grafiknesne.DrawEllipse(firca3, 30, 150, 120, 120);

            label1.Text = "Drawing has been completed with success! You can check those 4 planes above.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Red, 5);
            grafiknesne.DrawLine(firca, 40,40, 100, 100);
            Brush firca1 = new SolidBrush(System.Drawing.Color.Red);
            Font yazi = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            grafiknesne.DrawString("Red Line", yazi, firca1, 5, 100);
      
           
            Pen firca2 = new Pen(System.Drawing.Color.Blue, 5);
            grafiknesne.DrawLine(firca2, 120,120, 170, 170);
            Brush firca3 = new SolidBrush(System.Drawing.Color.Blue);
            Font yazi2 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            grafiknesne.DrawString("Blue Line", yazi2, firca3, 5, 150);

            Pen firca4 = new Pen(System.Drawing.Color.Green, 5);
            grafiknesne.DrawLine(firca4, 150, 200, 250, 200);
            Brush firca5 = new SolidBrush(System.Drawing.Color.Green);
            Font yazi3 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            grafiknesne.DrawString("Green Line", yazi3, firca5, 5, 190);

            Pen firca6 = new Pen(System.Drawing.Color.HotPink, 5);
            grafiknesne.DrawLine(firca6,170, 200, 230, 250);
            Brush firca7 = new SolidBrush(System.Drawing.Color.HotPink);
            Font yazi4 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            grafiknesne.DrawString("Pink Line", yazi4, firca7, 5, 250);

            Pen firca8 = new Pen(System.Drawing.Color.Purple, 5);
            grafiknesne.DrawLine(firca8, 180, 230, 300, 300);
            Brush firca9 = new SolidBrush(System.Drawing.Color.Purple);
            Font yazi5 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            grafiknesne.DrawString("Purple Line", yazi5, firca9, 5, 300);
        }
    }
}
