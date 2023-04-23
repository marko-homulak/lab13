using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        private QuadCollection<IShape> basic;

        private BindingList<IShape> shapes;

        public Form1()
        {
            basic = new QuadCollection<IShape>();
            shapes = new BindingList<IShape>();
            InitializeComponent();
            Shapes_list.DataSource = shapes;
            Shapes_list.DisplayMember = "Name";
        }

        private void Add_Quadrilateral_btn_Click(object sender, EventArgs e)
        {
            Add_Quadrilateral add_Quadrilateral = new Add_Quadrilateral(shapes);
            add_Quadrilateral.Show();
        }

        private void Add_Parallelogram_btn_Click(object sender, EventArgs e)
        {
            Add_Parallelogram add_Parallelogram = new Add_Parallelogram(shapes);
            add_Parallelogram.Show();
        }

        private void Add_Rhombus_btn_Click(object sender, EventArgs e)
        {
            Add_Rhombus add_Rhombus = new Add_Rhombus(shapes);
            add_Rhombus.Show();
        }

        private void Add_Rectangle_btn_Click(object sender, EventArgs e)
        {
            Add_Rectangle add_Rectangle = new Add_Rectangle(shapes);
            add_Rectangle.Show();
        }

        private void Add_Square_btn_Click(object sender, EventArgs e)
        {
            Add_Square add_Square = new Add_Square(shapes);
            add_Square.Show();
        }

        private void Shapes_list_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_list_btn_Click(object sender, EventArgs e)
        {
            shapes.Clear();
        }

        private void Sort_btn_Click(object sender, EventArgs e)
        {
            IShape[] _shapes = new IShape[Shapes_list.Items.Count];
            for (int i = 0; i < Shapes_list.Items.Count; i++)
            {
                _shapes[i] = Shapes_list.Items[i] as IShape;
            }

            Array.Sort(_shapes);

            shapes.Clear();

            foreach (IShape shape in _shapes)
            {
                shapes.Add(shape);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (Shapes_list.SelectedItem != null)
            {
                shapes.Remove((IShape)Shapes_list.SelectedItem);
            }
        }

        private void Add_Clone_btn_Click(object sender, EventArgs e)
        {
            int storageCountForMomentOfEntering = shapes.Count;
            for (int i = 0; i < storageCountForMomentOfEntering; i++)
            {
                shapes.Add((IShape)shapes[i].Clone());
            }
        }
       
    }
}
