using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesEditor
{
    [Serializable]
    public class Circle : Shape
    {
        private float _radius;
        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        
        public Circle(Point location, Color color, bool fill, float radius) : base(location, color, fill)
        {
            _radius = radius;
        }
        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public override void Paint(Graphics g)
        {
            if (Fill)
            {
                var fillColor = Color.FromArgb(100, Selected ? Color.Red : Color);

                using (var brush = new SolidBrush(fillColor))
                    g.FillEllipse(brush, Location.X-_radius, Location.Y-_radius, Radius*2, Radius*2);
            }

            using (var pen = new Pen(Color, 3))
                g.DrawEllipse(pen, Location.X-_radius, Location.Y-_radius, Radius * 2, Radius * 2);

        }
        public override bool Contains(Point p)
        {
            return
                Math.Abs(_location.X - p.X) <= _radius &&
                Math.Abs(_location.Y - p.Y) <= _radius;
        }

        public override bool Intersects(Shape shape)
        {
            List<Point> list = new List<Point>();

            for(int i=0; i<36; i++)
            {
                list.Add(new Point(_location.X + Convert.ToInt32(_radius*Math.Cos((360/36)*i)), _location.Y + Convert.ToInt32(_radius*Math.Sin((360/36)*i))));
            }

            return list.Where(s => shape.Contains(s)).Count() > 0;
        }

        public override void UpdateFrame(Point capturePoint, Point mousePoint)
        {
            float x = capturePoint.X - mousePoint.X;
            float y = capturePoint.Y - mousePoint.Y;
            _radius = (float) Math.Sqrt((x * x) + (y * y));
        }
    }
}
