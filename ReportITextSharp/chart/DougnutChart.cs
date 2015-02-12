using ReportITextSharp.data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReportITextSharp.chart
{
    class DougnutChart
    {
        public static Chart getDougnutChart(BeanDounghtChartData bean)
        {
            // Create the structure to fill the chart
            List<Color> segments = mapColors(bean);

            // Create the chart
            Chart chart = new Chart();

            // Set Chart's Dimensions
            chart.Width = 2000;  //3000
            chart.Height = 1600; //3000

            // Sharper chart
            chart.AntiAliasing = AntiAliasingStyles.All;
            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            // Clear 
            chart.Legends.Clear();
            chart.ChartAreas.Clear();
            chart.Series.Clear();
            chart.BackColor = Color.White;

            // Segments' properties
            Double[]  yValues       = new Double[100];
            float[]   doughnutSizes = new float[100];
            bool[]    exploded      = new bool[100];

            for (int i = 0; i < 100; i++)
            {
                yValues[i] = 1;
                doughnutSizes[i] = 80; 
                exploded[i] = true;
            }


            ChartArea area;
            Series series;

            for (int i = 0; i < yValues.Length; i++)
            {
                area = new ChartArea("Area_" + i);
                area.Position = new ElementPosition(0, 0, 100, 100);
                area.BorderWidth = 0;
                area.InnerPlotPosition = new ElementPosition((100 - doughnutSizes[i]) / 2, (100 - doughnutSizes[i]) / 2, doughnutSizes[i], doughnutSizes[i]);
                area.BackColor = Color.Transparent;
                chart.ChartAreas.Add(area);

                series = new Series("Series_" + i);
                series.ChartType = SeriesChartType.Doughnut;
                series.BorderWidth = 0;
                series["DoughnutRadius"] = "60";
                series.ChartArea = area.Name;
                series.Points.DataBindY(yValues);
                chart.Series.Add(series);
            }

            //to set the colors for each data point at run time
            chart.ApplyPaletteColors();

            for (int i = 0; i < yValues.Length; i++)
            {
                for (int j = 0; j < yValues.Length; j++)
                {
                    if (j != i)
                    {
                        //setting the color to transparent affects default rendering it seems
                        chart.Series[i].Points[j].Color = Color.Transparent;
                    }
                    else
                    {
                        chart.Series[i].Points[j].Color = segments[i];
                        chart.Series[i].Points[j]["Exploded"] = exploded[j].ToString();
                    }
                }
            }

            return chart;
        }





        private static List<Color> mapColors(BeanDounghtChartData chartData)
        {
            List<Color> segments = new List<Color>();

            foreach (BeanDounghtChartElement element in chartData.elements)
            {
                for (int i = 0; i < Math.Round(element.value); i++)
                {
                    segments.Add(element.color);
                }
            }

            return segments;
        }

    }
}
