using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Equation
    {
        public double f(double t, double y)
        {
            return y - t * t + 1;   //y - t^2 + 1 \\ x^2 + 1 = y
        }
    }
}
