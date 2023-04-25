using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Rectangle : Quadrilateral
    {
        public override string name => "Rectangle";

        public Rectangle() { }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double CalculateArea()
        {
            return side1 * side2;
        }

        public override string ToString()
        {
            return $"{name} (side: {side1}, {side2}; area: {CalculateArea()})";
        }
    }
}
