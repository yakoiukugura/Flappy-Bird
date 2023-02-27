using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int gravity = 5, speed = 3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pipeDown.Left -= speed;
            pipeUp.Left -= speed;
            bird.Top += gravity;

            if (pipeDown.Left < -pipeDown.Width)
                pipeDown.Left = 670;
            if (pipeUp.Left < -pipeUp.Width)
                pipeUp.Left = 670;

            if (bird.Bounds.IntersectsWith(pipeUp.Bounds) || bird.Bounds.IntersectsWith(pipeDown.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                timer1.Enabled = false; 
                MessageBox.Show("Game Over!");
                this.Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            gravity = 5;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            gravity = -5;
        }
    }
}
