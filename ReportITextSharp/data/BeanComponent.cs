using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportITextSharp.data
{
    class BeanComponent
    {
        public string name { get; set; }
        public double total { get; set; }
        public List<BeanComponentElement> elements { get; set; }

        public BeanComponent(string name,
                             List<BeanComponentElement> elements)
        {
            this.name = name;
            this.elements = elements;

            foreach (BeanComponentElement bean in elements)
            {
                this.total += bean.column6;
            }
        }
    }
}
