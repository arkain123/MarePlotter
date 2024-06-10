using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml;
using System.IO;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;

namespace Client
{
    internal class Saver
    {
        public void SaveToExcel(string filename, string[] data, string usereq, double t0, double y0, double h, double tf)
        {
            FileInfo fileInfo = new FileInfo(filename);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Equation");
                worksheet.Cells[1, 1].Value = "Уравнение";
                worksheet.Cells[1, 2].Value = usereq;
                worksheet.Cells[2, 1].Value = "x0";
                worksheet.Cells[2, 2].Value = t0;
                worksheet.Cells[3, 1].Value = "y0";
                worksheet.Cells[3, 2].Value = y0;
                worksheet.Cells[4, 1].Value = "h";
                worksheet.Cells[4, 2].Value = h;
                worksheet.Cells[5, 1].Value = "tf";
                worksheet.Cells[5, 2].Value = tf;

                worksheet.Cells[7, 1].Value = "X";
                worksheet.Cells[7, 2].Value = "Y";

                int cell = 7;
                for (int i = 1; i < data.Length; i += 2)
                {

                    worksheet.Cells[cell, 1].Value = double.Parse(data[i - 1]);
                    worksheet.Cells[cell, 2].Value = double.Parse(data[i]);
                    cell++;
                }
                cell--;

                var chart = worksheet.Drawings.AddChart("График", eChartType.LineMarkers);
                var series = chart.Series.Add(worksheet.Cells["B7" + ":B" + cell.ToString()], worksheet.Cells["A7" + ":A" + cell.ToString()]);
                series.Header = "График ДУ";

                chart.Title.Text = "График уравнения " + usereq;
                chart.XAxis.Title.Text = "X";
                chart.YAxis.Title.Text = "Y";

                chart.SetPosition(0, 0, 3, 0);
                chart.SetSize(600, 400);

                package.Save();
            }
        }

        public void SaveToWord(Chart chart, string filePath)
        {
            string tempImagePath = Path.GetTempFileName() + ".png";
            SaveChartAsImage(chart, tempImagePath);

            var wordApp = new Word.Application();
            var document = wordApp.Documents.Add();

            try
            {
                var paragraph = document.Paragraphs.Add();
                paragraph.Range.InlineShapes.AddPicture(tempImagePath);

                document.SaveAs2(filePath);
            }
            finally
            {
                document.Close();
                wordApp.Quit();

                File.Delete(tempImagePath);
            }
        }

        private void SaveChartAsImage(Chart chart, string filePath)
        {
            using (var stream = new MemoryStream())
            {
                chart.SaveImage(stream, ChartImageFormat.Png);
                var bitmap = new Bitmap(stream);
                bitmap.Save(filePath);
            }
        }
    }
}
