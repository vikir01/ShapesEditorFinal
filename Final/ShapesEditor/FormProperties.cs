using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesEditor
{
    public partial class FormProperties : Form
    {
        private Shape _shape;
        public Shape Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }
        public FormProperties()
        {
            InitializeComponent();
        }

        private void buttonOK_MouseClick(object sender, MouseEventArgs e)
        {

            if (_shape is Rectangle)
            {
                ((Rectangle)_shape).Height = Int32.Parse(textBoxHeight.Text);
                ((Rectangle)_shape).Width = Int32.Parse(textBoxWidth.Text);
            }
            else if (_shape is Circle)
            {
                ((Circle)_shape).Radius = Int32.Parse(textBoxRadius.Text);
            }
            else if (_shape is Square)
            {
                ((Square)_shape).Size = Int32.Parse(textBoxSize.Text);
            }

            DialogResult = DialogResult.OK;


        }

        private void buttonCalcel_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            Shape.Color = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : Color.White;
            buttonColor.BackColor = Shape.Color;
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            if( _shape is Rectangle)
            {
                textBoxHeight.Text = ((Rectangle)_shape).Height.ToString();
                textBoxWidth.Text = ((Rectangle)_shape).Width.ToString();
                panelRectangle.Visible = true;
            }
            else if(_shape is Circle)
            {
                textBoxRadius.Text = ((Circle)_shape).Radius.ToString();
                panelCircle.Visible = true;
            }
            else if(_shape is Square)
            {
                textBoxSize.Text = ((Square)_shape).Size.ToString();
                panelSquare.Visible = true;
            }
            buttonColor.BackColor = Shape.Color;
        }
    }
}
