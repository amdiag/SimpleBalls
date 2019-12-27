using System;
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
            SimpleBall ball = new SimpleBall(this);
            ball.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleRandomBall randomBall = new SimpleRandomBall(this);
            randomBall.Show();
        }

        private void FormDemoClassSimpleBall_MouseClick(object sender, MouseEventArgs e)
        {
            //SimplePointBall pointBall = new SimplePointBall(this, e.X, e.Y);
            //pointBall.Show();
            SimplePointRandomColorBall randomColorPointBall = new SimplePointRandomColorBall(this, e.X, e.Y);
            randomColorPointBall.Show();
        }
    }
}
