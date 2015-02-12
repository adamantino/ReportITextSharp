using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportITextSharp.data
{
    class BeanDounghtChartData
    {
        public List<BeanDounghtChartElement> elements { get; set; }

        public BeanDounghtChartData(List<BeanDounghtChartElement> elements)
        {
            this.elements = elements;
        }
    }
}
