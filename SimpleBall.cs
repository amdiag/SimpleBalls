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
    public class SimpleBall
    {
        protected int _x = 100;
        protected int _y = 100;
        protected int _size = 15;
        protected Form _f;
        protected Brush _brush;
        protected Rectangle _r;
        protected int _vx, _vy;
        static Random _rnd = new Random();

        public SimpleBall(Form f)
        {
            _f = f;
            _brush = Brushes.Red;
            _vx = _rnd.Next(-20,20);
            _vy = _rnd.Next(-20, 20);
        }
        public void Show()
        {
            Graphics g = _f.CreateGraphics();
            _r = new Rectangle(_x, _y, _size, _size);
            g.FillEllipse(_brush, _r);
        }

        public void Go()
        {
            _x += _vx;
            _y += _vy;
        }
        public void Erase()
        {
            Graphics g = _f.CreateGraphics();
            _r = new Rectangle(_x, _y, _size, _size);
            g.FillEllipse(new SolidBrush(_f.BackColor), _r);
        }

        public void Move()
        {
            Erase();
            Go();
            Show();
        }
    }

    public class SimpleRandomBall:SimpleBall
    {
        protected Random _rnd = new Random();
        public SimpleRandomBall(Form f):base(f)
        {
            _x = _rnd.Next(0, f.ClientSize.Width);
            _y = _rnd.Next(0, f.ClientSize.Height);
        }
    }

    public class SimplePointBall:SimpleBall
    {
        //public SimplePointBall(Form f) : base(f) { }

        public SimplePointBall(Form f,int x, int y):base(f) {
            _x = x- _size;
            _y = y- _size;
        }
    }

    public class SimplePointColorBall : SimplePointBall
    {
        public SimplePointColorBall(Form f, int x, int y, Brush brush) : base(f, x, y)
        {
            _brush = brush;
        }
    }
    
    public class SimplePointRandomColorBall:SimplePointBall
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

    public class SimpleMoveBall : SimpleRandomBall
    {
        Timer _timerBall;
        
        public SimpleMoveBall(Form f) : base(f)
        {
            _timerBall = new Timer();
            _timerBall.Enabled = true;
            _timerBall.Interval = 100;
            _timerBall.Tick += TimerBall_Tick;
        }

        private void TimerBall_Tick(object sender, EventArgs e)
        {
            Move();
        }

        internal void Stop()
        {
            _timerBall.Enabled = false;
        }

        internal void Start()
        {
            _timerBall.Enabled = true;
        }

        internal bool GetTimerStatus() { return _timerBall.Enabled; }
    }

}