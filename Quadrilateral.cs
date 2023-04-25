using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Quadrilateral : Shape
    {
        public override string name => "Quadrilateral";

        protected double side1;

        protected double side2;

        protected double diagonal1;

        protected double diagonal2;

        protected double angleBetweenDiagonals;

        public Quadrilateral() { }

        public Quadrilateral(double diagonal1, double diagonal2, double angleBetweenDiagonals)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
            this.angleBetweenDiagonals = angleBetweenDiagonals;
        }

        public override double CalculateArea()
        {
            double alpha = angleBetweenDiagonals * Math.PI / 180;
            return 0.5 * diagonal1 * diagonal2 * Math.Sin(alpha);
        }

        public override string ToString()
        {
            return $"{name} (diagonal1: {diagonal1}, diagonal2: {diagonal2}, alpha: {angleBetweenDiagonals}; area: {CalculateArea()})";
        }
    }
}
