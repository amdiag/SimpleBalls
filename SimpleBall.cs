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
        protected int _x = 100;
        protected int _y = 100;
        protected int _size = 15;
        protected Form _f;
        protected Brush _brush;
        protected Rectangle _r;

        public SimpleBall(Form f)
        {
            _f = f;
            _brush = Brushes.Red;
            
        }
        public void Show()
        {
            Graphics g = _f.CreateGraphics();
            _r = new Rectangle(_x, _y, _size, _size);
            g.FillEllipse(_brush, _r);
        }
    }

    class SimpleRandomBall:SimpleBall
    {
        protected Random _rnd = new Random();
        public SimpleRandomBall(Form f):base(f)
        {
            _x = _rnd.Next(0, f.ClientSize.Width);
            _y = _rnd.Next(0, f.ClientSize.Height);
        }
    }

    class SimplePointBall:SimpleBall
    {
        //public SimplePointBall(Form f) : base(f) { }

        public SimplePointBall(Form f,int x, int y):base(f) {
            _x = x- _size;
            _y = y- _size;
        }
    }
    
    class SimplePointRandomColorBall:SimplePointBall
    {
        private static Random _rnd = new Random();
       
        public SimplePointRandomColorBall(Form f, int x, int y):base(f,x,y) {
            Graphics g = f.CreateGraphics();
            _brush = getRandomBrush();
        }

        public static Brush getRandomBrush()
        {
            Type brushesType = typeof(Brushes);
            PropertyInfo[] properties = brushesType.GetProperties();
            return (Brush)properties[_rnd.Next(properties.Length)].GetValue(null, null);
        }
    }

}