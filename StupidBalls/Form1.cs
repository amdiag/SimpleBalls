using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleBalls;


namespace StupidBalls
{
    public partial class FormSimpleBall : Form
    {
        SimpleMoveBall ball;
        int n = 10;
        List<SimpleMoveBall> _balls = new List<SimpleMoveBall>();
        public FormSimpleBall()
        {
            InitializeComponent();
        }

        private void FormSimpleBall_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //ball = new SimpleMoveBall(this);
            for (int i = 0; i < n; i++)
            {
                SimpleMoveBall ball = new SimpleMoveBall(this);
                ball.Show();
                _balls.Add(ball);
            }
            timerLostBalls.Enabled = true;
        }

        private void CatchButton_Click(object sender, EventArgs e)
        {
            if (ball.OnScreen())
            {
                MessageBox.Show("Yes");
            }
            else MessageBox.Show("No");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerLostBalls_Tick(object sender, EventArgs e)
        {
            int countLostBalls = 0;
            foreach (var ball in _balls){
                if (!ball.OnScreen()) countLostBalls++;
            }
            labelNumLostBall.Text = countLostBalls.ToString();
        }
    }
}
