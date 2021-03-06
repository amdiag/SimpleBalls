﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBalls
{
    public partial class FormDemoClassSimpleBall : Form
    {

        SimpleBall ball;
        //SimpleRandomBall randomBall;
        SimpleMoveBall randomBall;
        public FormDemoClassSimpleBall()
        {
            InitializeComponent();
        }

        /*void ShowBall()
        {
            Graphics g = this.CreateGraphics();
            Brush b = Brushes.Red;
            Rectangle r = new Rectangle(400, 400, 15, 15);
            g.FillEllipse(b, r);

        }*/

        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            ball = new SimpleBall(this);
            //ball = new SimpleMoveBall(this);
            ball.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //randomBall = new SimpleRandomBall(this);
            randomBall = new SimpleMoveBall(this);
            randomBall.Show();
        }

        private void FormDemoClassSimpleBall_MouseClick(object sender, MouseEventArgs e)
        {
            //SimplePointBall pointBall = new SimplePointBall(this, e.X, e.Y);
            //pointBall.Show();
            //SimplePointRandomColorBall randomColorPointBall = new SimplePointRandomColorBall(this, e.X, e.Y);
            SimplePointColorBall randomColorPointBall = new SimplePointColorBall(this, e.X, e.Y, Brushes.Aquamarine);
            randomColorPointBall.Show();
        }

        private void MoveCircle_Click(object sender, EventArgs e)
        {
            //ball.Move();
            timerBall.Enabled = true;
            timerBall.Interval = 100;
        }

        private void MoveRandomBall_Click(object sender, EventArgs e)
        {
            //randomBall.Move();
            //randomBall.Stop();
            if (randomBall.GetTimerStatus() == true) {
                randomBall.Stop();
                moveRandomCircle.Text = "Start";
            }
            else { 
                randomBall.Start();
                moveRandomCircle.Text = "Stop";
            }
        }

        private void timerBall_Tick(object sender, EventArgs e)
        {
            ball.Move();
        }
    }
}
