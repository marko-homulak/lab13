using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Rhombus : Parallelogram
    {
        public override string Name => "Rhombus";

        public override double CalculateArea()
        {
            return 0.5 * Diagonal1 * Diagonal2;
        }

        public override string ToString()
        {
            return $"{Name} (diagonal1: {Diagonal1}, diagonal2: {Diagonal2}; area: {CalculateArea()})";
        }
    }
}
