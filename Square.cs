using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Square : Rectangle
    {
        public override string Name => "Square";

        public override double CalculateArea()
        {
            return Side1 * Side1;
        }

        public override string ToString()
        {
            return $"{Name} (side: {Side1}; area: {CalculateArea()})";
        }
    }
}
