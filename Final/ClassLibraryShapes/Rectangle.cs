using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ShapesEditor
{
    [Serializable]
    public class Rectangle : Shape
    {
        private int _width;
        public int Width
        {
            get { return _width; }
            set {_width = value; }
        }
        private int _height;
        public int Height
        {
            get { return _height; }
            set {_height = value; }
        }
        
        public Rectangle(Point location, Color color, bool fill, int width, int height) : base(location, color, fill)
        {
            _width = width;
            _height = height;
        }
        public override double Area()
        {
            return Height * Width;
        }

        public override void Paint(Graphics g)
        {
            if (Fill)
            {
                var fillColor = Color.FromArgb(100, Selected?Color.Red:Color);

                using (var brush = new SolidBrush(fillColor))
                    g.FillRectangle(brush, Location.X, Location.Y, Width, Height);
            }

            using (var pen = new Pen(Color, 3))
                g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
        }

        public override bool Contains(Point p)
        {
            return 
                Location.X < p.X && p.X < Location.X + Width &&
                   Location.Y < p.Y && p.Y < Location.Y + Height;
        }

        public override bool Intersects(Shape shape)
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(_location.X, _location.Y));
            list.Add(new Point(_location.X+_width, _location.Y));
            list.Add(new Point(_location.X, _location.Y+_height));
            list.Add(new Point(_location.X+_width, _location.Y+_height));

            return list.Where(s => shape.Contains(s)).Count() > 0;
        }

        public override void UpdateFrame(Point capturePoint, Point mousePoint)
        {
            _width = Math.Abs(capturePoint.X - mousePoint.X);
            _height = Math.Abs(capturePoint.Y - mousePoint.Y);

            _location.X = Math.Min(capturePoint.X, mousePoint.X);
            _location.Y = Math.Min(capturePoint.Y, mousePoint.Y);
        }
    }
}