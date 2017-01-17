using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nakov.TurtleGraphics;
using System.Windows.Forms;

namespace Turtle_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {

            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void Hexagon_Click(object sender, EventArgs e)
        {
           // В цикъл повторете 6 пъти следното: ротация на 60 градуса; движение напред 100.
           for(int i=0; i<6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }

        }

        private void Star_Click(object sender, EventArgs e)
        {
            //В цикъл повторете 5 пъти следното: движение напред 200, ротация на 144 градуса.
            Turtle.PenColor = Color.Green;
            for(int i=0; i<5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void Spiral_Click(object sender, EventArgs e)
        {
            int lenght = 0;
            for(int i=0; i<20; i++)
            {
                Turtle.Forward(lenght += 10);
                Turtle.Rotate(60);
            }
        }

        private void Sun_Click(object sender, EventArgs e)
        {
            for(int i=0; i<36; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(30);
                Turtle.Forward(100);
            }
        }
    }
}
