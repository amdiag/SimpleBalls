using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;

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

    class SimplePointBall
    {
        private int _x, _y, _r = 10;
       
        public SimplePointBall(Form f,int x, int y) {
            Graphics g = f.CreateGraphics();
            Brush b = Brushes.Green;
            _x = x-_r;
            _y = y-_r;
            Rectangle r = new Rectangle(_x, _y, 2*_r, 2*_r);
            g.FillEllipse(b, r);
        }
    }
    
    class SimplePointRandomColorBall
    {
        private static Random _rnd = new Random();
        private int _x, _y, _r = 10; 
        private Brush _brush;
       
        public SimplePointRandomColorBall(Form f, int x, int y) {
            Graphics g = f.CreateGraphics();
            
            _brush = getRandomBrush();
            _x = x - _r;
            _y = y - _r;
            Rectangle r = new Rectangle(_x, _y, 2 * _r, 2 * _r);
            g.FillEllipse(_brush, r);
        }


        public static Brush getRandomBrush()
        {
            Type brushesType = typeof(Brushes);

            PropertyInfo[] properties = brushesType.GetProperties();

            return (Brush)properties[_rnd.Next(properties.Length)].GetValue(null, null);
        }
    }

}