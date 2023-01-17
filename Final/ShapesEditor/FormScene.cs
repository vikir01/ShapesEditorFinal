using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesEditor
{
    public partial class Form1 : Form
    {
        private List<Shape> _shapes = new List<Shape>();

        private bool _captureMouse;
        private bool _isMoving;
        private Point _captureLocation;
        private Shape _frame;
        private string selectedShape = "rectangle";

        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var shape in _shapes)
                shape.Paint(e.Graphics);

            if(_captureMouse && _frame != null)
            {
                _frame.Paint(e.Graphics);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data"))
            {
                return;
            }
            else
            {
                var formatter = new BinaryFormatter();
                using(var stream = new FileStream("data", FileMode.Open))
                {
                    _shapes = (List<Shape>)formatter.Deserialize(stream);
                }
                updatePropertiesOption();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(_captureMouse)
                return;

            _captureLocation = e.Location;
            _captureMouse = true;

            if (_shapes.Where(s=>s.Contains(e.Location)&&s.Selected).Count() > 0)
            {
                _isMoving = true;
            }
            else
            {
                switch (selectedShape)
                {
                    case "rectangle":
                        _frame = new Rectangle(new Point(e.Location.X, e.Location.Y), Color.Gray, false, 0, 0);
                        break;
                    case "square":
                        _frame = new Square(new Point(e.Location.X, e.Location.Y), Color.Gray, false, 0);
                        break;
                    case "circle":
                        _frame = new Circle(new Point(e.Location.X, e.Location.Y), Color.Gray, false, 0);
                        break;
                }
            }

            Invalidate();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                return;
            }
            else
            {
                _shapes = _shapes.Where(s => !s.Selected).ToList();
            }

            RefreshArea();
            Invalidate();
        }
        private void RefreshArea()
        {
            var area = 0.0;
            foreach (var shape in _shapes)
                area += shape.Area();

            toolStripStatusLabel1.Text = area.ToString();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_captureMouse)
                return;

            if (_isMoving)
            {
                Point distance = new Point(e.Location.X-_captureLocation.X, e.Location.Y-_captureLocation.Y);
                foreach (var shape in _shapes)
                {
                    if (shape.Selected)
                    {
                        shape.Location = new Point(shape.Location.X + distance.X, shape.Location.Y + distance.Y);
                    }
                }
                _captureLocation = e.Location;
            }
            else
            {
                _frame.UpdateFrame(_captureLocation, e.Location);

                foreach (var shape in _shapes)
                    shape.Selected = shape.Intersects(_frame) || _frame.Intersects(shape);
                updatePropertiesOption();
            }

            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_captureMouse)
                return;

            if (_isMoving)
            {
                _isMoving = false;
            }
            else if (e.Button == MouseButtons.Right && _frame != null)
            {
                _frame.Fill = true;
                _frame.Selected = false;
                _frame.Color = Color.Blue;

                _shapes.Add(_frame);
            }
            _frame = null;
            _captureMouse = false;
            updatePropertiesOption();

            RefreshArea(); 
            Invalidate();
        }

        private void Properties()
        {
            var shape = _shapes
              .FirstOrDefault(r => r.Selected);

            if (shape != null)
            {
                var rs = new FormProperties()
                {
                    Shape = shape
                };

                rs.ShowDialog();

                RefreshArea();
                Invalidate();
            }
        }

        private void FormScene_DoubleClick(object sender, EventArgs e)
        {
            _shapes.ForEach(s => s.Selected = false);
            Shape shape = _shapes.Where(s => s.Contains((e as MouseEventArgs).Location)).FirstOrDefault();
            if (shape == null)
                return;
            shape.Selected = true;
            updatePropertiesOption();

            RefreshArea();
            Invalidate();
            Properties();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream("data", FileMode.Create))
            {
                formatter.Serialize(stream, _shapes);
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties();
        }

        private void updatePropertiesOption()
        {
            propertiesToolStripMenuItem.Enabled = _shapes.Where(s=>s.Selected).Count() == 1;
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _shapes = _shapes.Where(s => !s.Selected).ToList();

            RefreshArea();
            Invalidate();
        }

        private void deselectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _shapes.ForEach(s=>s.Selected = false);

            RefreshArea();
            Invalidate();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "rectangle";
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "square";
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "circle";
        }

        private void changeShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
