﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private bool _canDraw;
        private int _startX, _startY;
        private Rectangle _rect;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //The system is now allowed to draw rectangles
            _canDraw = true;
            //Initialize and keep track of the start position
            _startX = e.X;
            _startY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //The system is no longer allowed to draw rectangles
            _canDraw = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //If we are not allowed to draw, simply return and disregard the rest of the code
            if (!_canDraw) return;

            //The x-value of our rectangle should be the minimum between the start x-value and the current x-position
            int x = Math.Min(_startX, e.X);
            //The y-value of our rectangle should also be the minimum between the start y-value and current y-value
            int y = Math.Min(_startY, e.Y);

            //The width of our rectangle should be the maximum between the start x-position and current x-position minus
            //the minimum of start x-position and current x-position
            int width = Math.Max(_startX, e.X) - Math.Min(_startX, e.X);

            //For the hight value, it's basically the same thing as above, but now with the y-values:
            int height = Math.Max(_startY, e.Y) - Math.Min(_startY, e.Y);
            _rect = new Rectangle(x, y, width, height);
            //Refresh the form and draw the rectangle
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Create a new 'pen' to draw our rectangle with, give it the color red and a width of 2
            using (Pen pen = new Pen(Color.Red, 2))
            {
                //Draw the rectangle on our form with the pen
                e.Graphics.DrawRectangle(pen, _rect);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }
    }
}
