using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Quadrilateral : Shape
    {
        public override string Name => "Quadrilateral";

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }
        public double angleBetweenDiagonals { get; set; }

        public override double CalculateArea()
        {
            double alpha = angleBetweenDiagonals * Math.PI / 180;
            return 0.5 * Diagonal1 * Diagonal2 * Math.Sin(alpha);
        }

        public override string ToString()
        {
            return $"{Name} (diagonal1: {Diagonal1}, diagonal2: {Diagonal2}, alpha: {angleBetweenDiagonals}; area: {CalculateArea()})";
        }
    }
}
