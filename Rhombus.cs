using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Rhombus : Quadrilateral
    {
        public override string name => "Rhombus";

        public Rhombus() { }

        public Rhombus(double diagonal1, double diagonal2)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public override double CalculateArea()
        {
            return 0.5 * diagonal1 * diagonal2;
        }

        public override string ToString()
        {
            return $"{name} (diagonal1: {diagonal1}, diagonal2: {diagonal2}; area: {CalculateArea()})";
        }
    }
}
