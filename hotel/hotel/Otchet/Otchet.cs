using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace hotel.Otchet
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
            chart1.Visible = false;
        }

        private void Otchet_Load(object sender, EventArgs e)
        {

        }
        Mapping.DBjurnal dbj = new Mapping.DBjurnal(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            var linq = from n in dbj.Jurnal
                       select n;
            dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(1 - dateTimePicker1.Value.Day);
            dateTimePicker2.Value = dateTimePicker2.Value.Date.AddMonths(1).AddDays(-dateTimePicker2.Value.Day);
            for (var dateFrom = dateTimePicker1.Value; dateFrom <= dateTimePicker2.Value; dateFrom = dateFrom.AddMonths(1))
            {
                var dateTo = dateFrom.AddMonths(1).AddDays(-1);
                var trips = dbj.Jurnal.Where(t => t.data >= dateFrom && t.data <= dateTo);
                foreach (var i in trips)
                {
                    {
                        chart1.Series[0].Points.AddXY(GetMonth(dateFrom.Month), i.summa);
                    }
                }

                //int sum = trips.Any() ? trips.Sum(p => p.IDRaspisania) : 0;

            }
        }
        public static string GetMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "январь";
                case 2:
                    return "февраль";
                case 3:
                    return "март";
                case 4:
                    return "апрель";
                case 5:
                    return "май";
                case 6:
                    return "июнь";
                case 7:
                    return "июль";
                case 8:
                    return "август";
                case 9:
                    return "сентябрь";
                case 10:
                    return "октябрь";
                case 11:
                    return "ноябрь";
                case 12:
                    return "декабрь";
                default:
                    return "нет такого месяца";
            }
        }
        private static readonly string Dir = Application.StartupPath + "\\ExcelFiles";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Dir + "\\" + string.Format("{0}.xls", Guid.NewGuid()).Replace(" ", "_");
                //if (File.Exists(fileName))
                //{
                //    try
                //    {
                //        File.Delete(fileName);
                //    }
                //    catch (Exception)
                //    {
                //        MessageBox.Show(string.Format("В настоящий момент используется файл:\r\n{0}\r\nДля создания договора закройте пожалуйста файл.", fileName),
                //            "Невозможно создать договор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
                //}

                Excel.Application xla = new Excel.Application();
                xla.Visible = true;
                Excel.Workbook wb = xla.Workbooks.Add(Excel.XlSheetType.xlWorksheet);

                Excel.Worksheet ws = (Excel.Worksheet)xla.ActiveSheet;


                // Now create the chart.
                Excel.ChartObjects chartObjs = (Excel.ChartObjects)ws.ChartObjects();
                Excel.ChartObject chartObj = chartObjs.Add(512, 80, 300, 300);
                Excel.Chart xlChart = chartObj.Chart;
                xlChart.ChartType = Excel.XlChartType.xlBarClustered;
                // generate some random data
                dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(1 - dateTimePicker1.Value.Day);
                dateTimePicker2.Value = dateTimePicker2.Value.Date.AddMonths(1).AddDays(-dateTimePicker2.Value.Day);

                ws.Cells[2, 2] = string.Format("Результативность работы фирмы за период с {0} по {1}", dateTimePicker1.Value, dateTimePicker2.Value);
                ws.Cells[4, 3] = "Период";
                ws.Cells[4, 4] = "Количество сделок";
                ws.Cells[4, 5] = "Сумма";

                int row = 5;
                for (var dateFrom = dateTimePicker1.Value; dateFrom <= dateTimePicker2.Value; dateFrom = dateFrom.AddMonths(1))
                {
                    var dateTo = dateFrom.AddMonths(1).AddDays(-1);
                    var trips = dbj.Jurnal.Where(t => t.data >= dateFrom && t.data <= dateTo);
                    foreach (var i in trips)
                    {
                         ws.Cells[row, 3] = GetMonth(dateFrom.Month);
                         ws.Cells[row, 4] = trips.Count();
                        ws.Cells[row, 5] = i.summa;
                    }
                   

                    row++;
                }

                Excel.Range xValues = ws.Range["C5", "C" + (row - 1)];
                Excel.Range values = ws.Range["E5", "E" + (row - 1)];

                Excel.SeriesCollection seriesCollection = xlChart.SeriesCollection();

                Excel.Series series1 = seriesCollection.NewSeries();
                series1.XValues = xValues;
                series1.Values = values;
                //xla.ActiveChart.HasTitle = true;
                //xla.ActiveChart.ChartTitle.Text = "Тестовая диаграмма";

                //xla.ActiveChart.ChartTitle.Font.Size = 13;
                //xla.ActiveChart.ChartTitle.Font.Color = 254;

                //xla.ActiveChart.ChartTitle.Shadow = true;
                //xla.ActiveChart.ChartTitle.Border.LineStyle = Excel.Constants.xlSolid;
            }
            catch { MessageBox.Show("Ошибка Excel не найден"); }
        }
    }
}
