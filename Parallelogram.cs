using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Parallelogram : Quadrilateral
    {
        public override string name => "Parallelogram";

        private double height;

        public Parallelogram() { }

        public Parallelogram(double side1, double height)
        {
            this.side1 = side1;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return side1 * height;
        }

        public override string ToString()
        {
            return $"{name} (side: {side1}, height: {height}; area: {CalculateArea()})";
        }
    }
}
