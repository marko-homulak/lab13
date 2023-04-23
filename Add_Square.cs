﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab11
{
    public partial class Add_Square : Form
    {
        private BindingList<IShape> shapes;
        public Add_Square(BindingList<IShape> shapes)
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
                double side1;

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception("Please fill in all fields.");
                }
                else
                {
                    if (!double.TryParse(textBox1.Text, out side1) || side1 <= 0)
                    {
                        throw new ArgumentException("Side1 must be a positive number.");
                    }
                }
                
                shape = new Square()
                {
                    Side1 = double.Parse(textBox1.Text)
                };

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