using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class RungeKutta
    {
        public Equation eq = new Equation();

        public double Solve(double t0, double y0, double h, double tf)
        {
            double k1, k2, k3, k4, y;
            double t = t0;
            double y_res = y0;

            while (t < tf)
            {
                k1 = h * eq.f(t, y_res);
                k2 = h * eq.f(t + h / 2, y_res + k1 / 2);
                k3 = h * eq.f(t + h / 2, y_res + k2 / 2);
                k4 = h * eq.f(t + h, y_res + k3);

                y = y_res + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                y_res = y;
                t += h;
            }

            return y_res;
        }
    }
}
