using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public abstract class Shape : IShape 
    {
        public virtual string Name => "Shape";

        public abstract double CalculateArea();

        public override string ToString()
        {
            return $"{Name}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(IShape other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
