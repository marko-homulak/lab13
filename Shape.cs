using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public abstract class Shape : IShape
    {
        public virtual string name => "Shape";

        public abstract double CalculateArea();

        public override string ToString()
        {
            return $"{name}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(IShape other)
        {
            return name.CompareTo(other.name);
        }
    }
}
