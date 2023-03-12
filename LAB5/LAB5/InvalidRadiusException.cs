using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException()
        : base("Radius is greater than zero")
        {
        }

        public InvalidRadiusException(double radius)
            : base($"Invalid radius: {radius} is not greater than zero")
        {
        }
    }
}
