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
    public partial class Add_Rhombus : Form
    {
        private BindingList<IShape> shapes;
        public Add_Rhombus(BindingList<IShape> shapes)
        {
            this.shapes = shapes;
            InitializeComponent();
        }

        Shape shape;

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Get_Area_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double diagonal1, diagonal2;

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    throw new Exception("Please fill in all fields.");
                }
                else
                {
                    if (!double.TryParse(textBox1.Text, out diagonal1) || diagonal1 <= 0)
                    {
                        throw new ArgumentException("Diagonal1 must be a positive number.");
                    }

                    if (!double.TryParse(textBox2.Text, out diagonal2) || diagonal2 <= 0)
                    {
                        throw new ArgumentException("Diagonal2 must be a positive number.");
                    }
                }

                if (diagonal1 == diagonal2)
                {
                    shape = new Square()
                    {
                        Side1 = diagonal1 / Math.Sqrt(2)
                    };
                }
                else
                {
                    shape = new Rhombus()
                    {
                        Diagonal1 = diagonal1,
                        Diagonal2 = diagonal2
                    };
                }
                              
                shapes.Add(shape);

                MessageBox.Show("Area of the " + shape.Name + " = " + shape.CalculateArea());

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
