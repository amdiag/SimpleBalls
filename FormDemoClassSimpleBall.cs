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
        }
    }
}
