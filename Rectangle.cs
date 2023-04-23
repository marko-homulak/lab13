using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Rectangle : Parallelogram
    {
        public override string Name => "Rectangle";

        public override double CalculateArea()
        {
            return Side1 * Side2;
        }

        public override string ToString()
        {
            return $"{Name} (side: {Side1}, {Side2}; area: {CalculateArea()})";
        }
    }
}
