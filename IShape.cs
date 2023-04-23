using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public interface IShape : ICloneable, IComparable<IShape>
    {
        string Name { get; }
        double CalculateArea();
    }
}
