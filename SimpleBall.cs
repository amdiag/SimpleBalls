using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBalls
{
    class SimpleBall
    {
        public SimpleBall(Form f)
        {
            Graphics g = f.CreateGraphics();
            Brush b = Brushes.Red;
            Rectangle r = new Rectangle(400, 400, 15, 15);
            g.FillEllipse(b, r);
        }
    }

    class SimpleRandomBall
    {
        private int x, y;
        private Random rnd = new Random();
        public SimpleRandomBall(Form f)
        {
            Graphics g = f.CreateGraphics();
            Brush b = Brushes.Green;
            x = rnd.Next(0, 700);
            y = rnd.Next(0, 350);
            Rectangle r = new Rectangle(x, y, 20, 20);
            g.FillEllipse(b, r);
        }
    }
}