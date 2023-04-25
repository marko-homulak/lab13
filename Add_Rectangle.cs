using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab11
{
    public partial class Add_Rectangle : Form
    {

        private BindingList<IShape> shapes;

        public Add_Rectangle(BindingList<IShape> shapes)
        {
            this.shapes = shapes;
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Get_Area_btn_Click(object sender, EventArgs e)
        {
            Shape shape;

            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    throw new Exception("Please fill in all fields.");
                }
                else
                {
                    double side1, side2;

                    if (!double.TryParse(textBox1.Text, out side1) || side1 <= 0)
                    {
                        throw new ArgumentException("Side1 must be a positive number.");
                    }

                    if (!double.TryParse(textBox2.Text, out side2) || side2 <= 0)
                    {
                        throw new ArgumentException("Side2 must be a positive number.");
                    }

                    if (side1 == side2)
                    {
                        shape = new Square(side1);
                    }
                    else
                    {
                        shape = new Rectangle(side1, side2);
                    }
                }

                shapes.Add(shape);

                MessageBox.Show("Shape: " + shape.name + " successfully added");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
