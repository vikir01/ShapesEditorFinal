using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesEditor
{
    [Serializable]
    public abstract class Shape
    {
        protected Point _location;
        public Point Location
        {
            get { return _location; }
            set { _location = value; }
        }
        protected Color _color;
        public Color Color {
            get { return _color; }
            set { _color = value; }
        }
        protected bool _fill = true;
       
        public bool Fill
        {
            get { return _fill; }
            set { _fill = value; }
        }
        
        protected bool _selected = true;
        public bool Selected {
            get { return _selected; }
            set { _selected = value; }
        }

        public delegate void OnClickDelegate(Shape shape);
        public OnClickDelegate OnClick = null;

        public Shape(Point location, Color color, bool fill)
        {
            _location = location;
            _color = color;
            _fill = fill;
        }
        public abstract double Area();

        public abstract void Paint(Graphics g);

        public abstract bool Contains(Point p);

        public abstract bool Intersects(Shape shape);

        public void Move(int x, int y)
        {
            _location.X = x;
            _location.Y = y;
        }

        public abstract void UpdateFrame(Point capturePoint, Point mousePoint);

    }
}
