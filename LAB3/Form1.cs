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
        Graphics Draw;
        public Form1()
        {
            InitializeComponent();
            Draw = pictureBox1.CreateGraphics();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            Draw.Clear(Color.White);

            //Rectangle
            Pen firca = new Pen(System.Drawing.Color.Red, 5);
            Draw.DrawRectangle(firca, 30, 40, 150, 50);
            //square
            Pen firca1 = new Pen(System.Drawing.Color.Blue, 5);
            Draw.DrawRectangle(firca1, 250, 150, 120, 120);
            //ellipse
            Pen firca2 = new Pen(System.Drawing.Color.Black, 5);
            Draw.DrawEllipse(firca2, 250, 40, 150, 50);
            //circle
            Pen firca3 = new Pen(System.Drawing.Color.Green, 5);
            Draw.DrawEllipse(firca3, 30, 150, 120, 120);

            label1.Text = "Drawing has been completed with success! You can check those 4 planes down bellow.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Draw.Clear(Color.White);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            Draw.Clear(Color.White);
            Pen firca = new Pen(System.Drawing.Color.Red, 5);
            Draw.DrawLine(firca, 40, 40, 100, 100);
            Brush firca1 = new SolidBrush(System.Drawing.Color.Red);
            Font yazi = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            Draw.DrawString("Red Line", yazi, firca1, 5, 100);


            Pen firca2 = new Pen(System.Drawing.Color.Blue, 5);
            Draw.DrawLine(firca2, 120, 120, 170, 170);
            Brush firca3 = new SolidBrush(System.Drawing.Color.Blue);
            Font yazi2 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            Draw.DrawString("Blue Line", yazi2, firca3, 5, 150);

            Pen firca4 = new Pen(System.Drawing.Color.Green, 5);
            Draw.DrawLine(firca4, 150, 200, 250, 200);
            Brush firca5 = new SolidBrush(System.Drawing.Color.Green);
            Font yazi3 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            Draw.DrawString("Green Line", yazi3, firca5, 5, 190);

            Pen firca6 = new Pen(System.Drawing.Color.HotPink, 5);
            Draw.DrawLine(firca6, 170, 200, 230, 250);
            Brush firca7 = new SolidBrush(System.Drawing.Color.HotPink);
            Font yazi4 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            Draw.DrawString("Pink Line", yazi4, firca7, 5, 250);

            Pen firca8 = new Pen(System.Drawing.Color.Purple, 5);
            Draw.DrawLine(firca8, 180, 230, 300, 300);
            Brush firca9 = new SolidBrush(System.Drawing.Color.Purple);
            Font yazi5 = new System.Drawing.Font("Helvetica", 12, FontStyle.Italic);
            Draw.DrawString("Purple Line", yazi5, firca9, 5, 270);
            label1.Text = "Drawing has been completed with success! You can check those 5 lines down bellow.";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            Pen kalemim = new Pen(Color.Red, 2);
            Pen kalemim2 = new Pen(Color.Blue, 2);




            Draw.Clear(Color.White);
            Point[] p1 = { new Point(100, 60), new Point(125, 100), new Point(150, 150), new Point(200, 50) };
            Draw.DrawCurve(kalemim, p1, 1);

            Point[] p2 = { new Point(100, 120), new Point(125, 200), new Point(300, 250), new Point(200, 100) };
            Draw.DrawCurve(kalemim2, p2, 2);
            label1.Text = "Drawing has been completed with success! You can check those 2 bezier curves down bellow.";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Draw.Clear(Color.White);
            label1.Visible = false;


        }



        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Draw.Clear(Color.White);
            }
        }

        public int xInit = 0, yInit = 0;
        public int xFinal = 0, yFinal = 0;

        Bitmap image1;

        private void button7_Click(object sender, EventArgs e)
        {
            
            //Red
            Brush dolgu = new SolidBrush(System.Drawing.Color.Red);
            //Yellow
            Brush dolgu1 = new SolidBrush(System.Drawing.Color.Yellow);
            //Black 
            Brush dolgu2 = new SolidBrush(System.Drawing.Color.Black);
            Draw.FillRectangle(dolgu, 20, 20, 200, 100);
            Draw.FillRectangle(dolgu1, 20, 125, 50, 50);
            Draw.FillEllipse(dolgu2, 20, 180, 100, 50);
            Draw.FillEllipse(dolgu, 20, 240, 50, 50);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the image.
                image1 = new Bitmap(@"D:\FAF\2.Sınıf\2.Dönem\WP\LAB3\wp.bmp", true);

                int x, y;

                // Loop through the images pixels to reset color.
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                        image1.SetPixel(x, y, newColor);
                    }
                }

                // Set the PictureBox to display the image.
                pictureBox1.Image = image1;

                // Display the pixel format in Label1.
                label1.Text = "Pixel format: " + image1.PixelFormat.ToString();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                xFinal = e.X;
                yFinal = e.Y;

                Pen Bluepen = new Pen(Color.Blue, 5);
                Pen Yellow = new Pen(Color.Yellow, 5);


                Rectangle commonRect = new Rectangle(xInit, yInit, xFinal, yFinal);
                

                Draw.DrawEllipse(Bluepen, commonRect);
                Point[] p1 = { new Point(100, 60), new Point(125, 100), new Point(150, 150), new Point(200, 50) };
                Draw.DrawCurve(Yellow, p1, 1);

            }
        }
    }
}
