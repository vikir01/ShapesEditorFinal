using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesEditor
{
    [Serializable]
    public class Square : Shape
    {
        private float _size;
        public float Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public Square(Point location, Color color, bool fill, float size) : base(location, color, fill)
        {
            _size = size;
        }
        public override double Area()
        {
            return Size * Size;
        }

        public override void Paint(Graphics g)
        {
            if (Fill)
            {
                var fillColor = Color.FromArgb(100, Selected ? Color.Red : Color);

                using (var brush = new SolidBrush(fillColor))
                    g.FillRectangle(brush, Location.X, Location.Y, Size, Size);
            }

            using (var pen = new Pen(Color, 3))
                g.DrawRectangle(pen, Location.X, Location.Y, Size, Size);

        }
        public override bool Contains(Point p)
        {
            return
                Location.X < p.X && p.X < Location.X + Size &&
                   Location.Y < p.Y && p.Y < Location.Y + Size;
        }

        public override bool Intersects(Shape shape)
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(_location.X, _location.Y));
            list.Add(new Point(_location.X + (int)_size, _location.Y));
            list.Add(new Point(_location.X, _location.Y + (int)_size));
            list.Add(new Point(_location.X + (int)_size, _location.Y + (int)_size));

            return list.Where(s => shape.Contains(s)).Count() > 0;
        }

        public override void UpdateFrame(Point capturePoint, Point mousePoint)
        {
            _size = Math.Max(
                Math.Abs(capturePoint.X - mousePoint.X),
                Math.Abs(capturePoint.Y - mousePoint.Y));
            
            _location.X = Math.Min(capturePoint.X, mousePoint.X);
            _location.Y = Math.Min(capturePoint.Y, mousePoint.Y);
            
        }
    }
}
