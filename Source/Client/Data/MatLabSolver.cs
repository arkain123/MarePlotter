using System.Globalization;

namespace Client
{
    internal class MatLabSolver
    {
        public string RunCalculation(MLApp.MLApp matlab, double input_y0, double input_t0, double input_tf, double input_h, string usereq)
        {

            string t0 = input_t0.ToString(CultureInfo.InvariantCulture);
            string y0 = input_y0.ToString(CultureInfo.InvariantCulture);
            string h = input_h.ToString(CultureInfo.InvariantCulture);
            string tf = input_tf.ToString(CultureInfo.InvariantCulture);

            matlab.Execute($"t0 = {t0}");
            matlab.Execute($"y0 = {y0}");
            matlab.Execute("tf = " + tf);
            matlab.Execute($"h = {h}");
            matlab.Execute($"f = @(x,y) {usereq}");

            matlab.Execute("x = t0:h:tf");
            matlab.Execute("n = length(x)");
            matlab.Execute("y = zeros(1, n)");
            matlab.Execute("y(1) = y0");
            matlab.Execute("for i = 1:n-1\r\n" +
                "                    k1 = h * feval(f, x(i), y(i));\r\n" +
                "                    k2 = h * feval(f, x(i) + 0.5*h, y(i) + 0.5*k1);\r\n" +
                "                    k3 = h * feval(f, x(i) + 0.5*h, y(i) + 0.5*k2);\r\n" +
                "                    k4 = h * feval(f, x(i) + h, y(i) + k3);\r\n" +
                "                    y(i+1) = y(i) + (k1 + 2*k2 + 2*k3 + k4) / 6;\r\n" +
                "                end");
            matlab.Execute("result = [x' y']");
            matlab.Execute("plot(x, y);\r\n" +
                "                xlabel('x');\r\n" +
                "                ylabel('y');\r\n" +
                "                title('Plot');");
            string result = matlab.Execute("result(n, 2)").Replace("\n", "").Replace("ans =", "").Replace(" ", "");
            //"\nans =\n\n    1.4256\n\n" - without
            //"ans =\n\n    1.4256" - Trim
            return result;
        }
    }
}
