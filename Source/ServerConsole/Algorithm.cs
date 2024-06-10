using System;
using System.Collections.Generic;

namespace Server
{
    internal class Algorithm
    {

        private double t0, y0, h, tf;
        private string usereq;
        private List<(double x, double y)> points = new List<(double x, double y)>();

        public double T0 { get; set; }
        public double Y0 { get; set; }
        public double H { get; set; }
        public double Tf { get; set; }
        public string Usereq { get; set; }
        public List<(double x, double y)> Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public void SetValues(double t0, double y0, double h, double tf, string eq)
        {
            T0 = t0;
            Y0 = y0;
            H = h;
            Tf = tf;
            Usereq = eq;
            Points.Clear();
        }

        public string[] Solve()
        {
            Equation eq = new Equation(Usereq);
            double t = T0;
            double y = Y0;
            double k1, k2, k3, k4;
            (double x, double y) dot = (t, y);
            Points.Add(dot);

            while (t < Tf)
            {
                k1 = eq.f(t, y);
                k2 = eq.f(t + H / 2, y + (H * k1 / 2));
                k3 = eq.f(t + H / 2, y + (H * k2 / 2));
                k4 = eq.f(t + H, y + (H * k3));

                y = y + ((H / 6) * (k1 + 2 * k2 + 2 * k3 + k4));
                t = t + H;
                dot = (t, y);
                Points.Add(dot);
            }

            return ParseTuplesToStrings(Points);
        }

        public string[] ParseTuplesToStrings(List<(double x, double y)> tuples)
        {
            List<string> result = new List<string>();

            foreach (var tuple in tuples)
            {
                result.Add(Math.Round(tuple.Item1, 5).ToString());
                result.Add(Math.Round(tuple.Item2, 5).ToString());
            }

            return result.ToArray();
        }
    }
}
