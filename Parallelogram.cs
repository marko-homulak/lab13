using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Parallelogram : Quadrilateral
    {
        public override string Name => "Parallelogram";

        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Side1 * Height;
        }

        public override string ToString()
        {
            return $"{Name} (side: {Side1}, height: {Height}; area: {CalculateArea()})";
        }
    }
}
