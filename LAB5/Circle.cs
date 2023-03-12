using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    internal class Circle
    {
        private double Radius;

        public void SetRadius(double r)
        {
            if (r > 0)
                Radius = r;
            else
                throw new InvalidRadiusException(r);
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}";
        }
    }
}
