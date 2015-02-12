using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportITextSharp.data
{
    class BeanDounghtChartElement
    {
        public string name { get; set; }
        public double value { get; set; }
        public Color color { get; set; }

        public BeanDounghtChartElement(string name, double value, Color color)
        {
            this.name = name;
            this.value = value;
            this.color = color;
        }
    }
}
