using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Media;
using System.Drawing.Drawing2D;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Some drawing parameters.
        private const int BallWidth = 50;
        private const int BallHeight = 50;
        private int BallX, BallY;   // Position.
        private int BallVx, BallVy; // Velocity.
        private int RecX, RecY;   // Position.
        private int RecVx, RecVy; // Velocity.
        private int Rec2X, Rec2Y;   // Position.
        private int Rec2Vx, Rec2Vy; // Velocity.

        // Initialize some random stuff.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Pick a random start position and velocity.
            Random rnd = new Random();
            BallVx = rnd.Next(1, 4);
            BallVy = rnd.Next(1, 4);
            RecVx = rnd.Next(1, 2);
            RecVy = rnd.Next(1, 2);
            Rec2Vx = rnd.Next(1, 5);
            Rec2Vy = rnd.Next(1, 5);
            BallX = rnd.Next(0, ClientSize.Width - BallWidth);
            BallY = rnd.Next(0, ClientSize.Height - BallHeight);
            RecX = rnd.Next(0, ClientSize.Width - BallWidth);
            RecY = rnd.Next(0, ClientSize.Height - BallHeight);
            Rec2X = rnd.Next(0, ClientSize.Width - BallWidth);
            Rec2Y = rnd.Next(0, ClientSize.Height - BallHeight);

            // Use double buffering to reduce flicker.
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            this.UpdateStyles();
        }

      
        private void tmrMoveBall_Tick(object sender, EventArgs e)
        {
            BallX += BallVx;
            if (BallX < 0)
            {
                BallVx = -BallVx;
                
            }
            else if (BallX + BallWidth > ClientSize.Width)
            {
                BallVx = -BallVx;
                
            }

            BallY += BallVy;
            if (BallY < 0)
            {
                BallVy = -BallVy;
                
            }
            else if (BallY + BallHeight > ClientSize.Height)
            {
                BallVy = -BallVy;
                
            }

       //2
            
                RecX += RecVx;
            if (RecX < 0)
            {
                RecVx = -RecVx;
               
            }
            else if (RecX + BallWidth > ClientSize.Width)
            {
                RecVx = -RecVx;
                
            }

            RecY += RecVy;
            if (RecY < 0)
            {
                RecVy = -RecVy;
               
            }
            else if (RecY + BallHeight > ClientSize.Height)
            {
                RecVy = -RecVy;
              
            }

            //3

            Rec2X += Rec2Vx;
            if (Rec2X < 0)
            {
                Rec2Vx = -Rec2Vx;

            }
            else if (Rec2X + BallWidth > ClientSize.Width)
            {
                Rec2Vx = -Rec2Vx;

            }

            Rec2Y += Rec2Vy;
            if (Rec2Y < 0)
            {
                Rec2Vy = -Rec2Vy;

            }
            else if (Rec2Y + BallHeight > ClientSize.Height)
            {
                Rec2Vy = -Rec2Vy;

            }
            Refresh();
        }

       

        // Draw the ball at its current location.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);
            e.Graphics.FillEllipse(Brushes.Blue, BallX, BallY, BallWidth, BallHeight);
            e.Graphics.DrawEllipse(Pens.Black, BallX, BallY, BallWidth, BallHeight);
            e.Graphics.FillRectangle(Brushes.Red, RecX, RecY, BallWidth, BallHeight);
            e.Graphics.DrawRectangle(Pens.Black, RecX, RecY, BallWidth, BallHeight);
            e.Graphics.FillRectangle(Brushes.Pink, Rec2X, Rec2Y, 80, 30);
            e.Graphics.DrawRectangle(Pens.Black, Rec2X, Rec2Y, 80, 30);
            e.Graphics.FillRectangle(Brushes.Pink, Rec2X, Rec2Y, 80, 30);
            e.Graphics.DrawRectangle(Pens.Black, Rec2X, Rec2Y, 80, 30);

        }
    }
}
