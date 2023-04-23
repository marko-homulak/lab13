using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Add_Quadrilateral : Form
    {
        //private BindingList<IShape> shapes;

        private BindingList<IShape> shapes;

        public Add_Quadrilateral(BindingList<IShape> shapes)
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
                double diagonal1, diagonal2, angle; 

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
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

                    if (!double.TryParse(textBox3.Text, out angle) || angle <= 0 || angle > 180)
                    {
                        throw new ArgumentException("Angle α° must be in interval between 0 and 180.");
                    }
                }

                if (diagonal1 == diagonal2)
                {
                    if (angle == 90)
                    {
                        shape = new Square()
                        {
                            Side1 = diagonal1 / Math.Sqrt(2)
                        };
                    }
                    else
                    {
                        shape = new Rectangle()
                        { 
                            Side1 = Math.Sqrt(Math.Pow(diagonal1, 2) * (1 - Math.Cos(angle * Math.PI / 180) / 2)),
                            Side2 = Math.Sqrt(Math.Pow(diagonal1, 2) * (1 - Math.Cos((180 - angle) * Math.PI / 180) / 2))
                        };
                    }
                }
                else
                {
                    shape = new Quadrilateral()
                    {
                        Diagonal1 = diagonal1,
                        Diagonal2 = diagonal2,
                        angleBetweenDiagonals = angle
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
