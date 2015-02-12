using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportITextSharp.data
{
    class BeanComponentElement
    {

        public string column1 { get; set; }
        public string column2 { get; set; }
        public string column3 { get; set; }
        public double column4 { get; set; }
        public double column5 { get; set; }
        public double column6 { get; set; }
        public double column7 { get; set; }

        public BeanComponentElement(string column1,
                                    string column2,
                                    string column3,
                                    double column4,
                                    double column5,
                                    double column6,
                                    double column7)
        {
            this.column1 = column1;
            this.column2 = column2;
            this.column3 = column3;
            this.column4 = column4;
            this.column5 = column5;
            this.column6 = column6;
            this.column6 = column7;
        }
    }
}
