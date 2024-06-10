using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    internal class Graphic
    {
        private double[] points = new double[1];
        private Chart chart;
        private DataGridView dataGridView;

        public Graphic(string[] data, Chart ch, DataGridView dgv) 
        {
            chart = ch;
            dataGridView = dgv;
            points = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                points[i] = double.Parse(data[i]);
            }
        }

        public void Visualise()
        {
            dataGridView.Rows.Clear();
            chart.Series[0].Points.Clear();

            for (int i = 1; i < points.Length; i += 2)
            {
                chart.Series[0].Points.AddXY(points[i - 1], points[i]);
                dataGridView.Rows.Add(points[i - 1], points[i]);
            }
        }
    }
}
