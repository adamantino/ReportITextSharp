using ReportITextSharp.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportITextSharp
{
    class TestData
    {

        public static List<BeanComponent> getComposizioneDiDettaglioData()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());  // generate real random seeds
            double max = 99999999.99;

            string[] componenteName = { "Component 1",
                                        "Component 2",
                                        "Component 3",
                                        "Component 4",
                                        "Component 5"
                                       };

            List<BeanComponent> Component = new List<BeanComponent>();


            for (int subIndex = 0; subIndex < componenteName.Length; subIndex++)
            {
                List<BeanComponentElement> subCompList = new List<BeanComponentElement>();
                for (int i = 0; i < rnd.Next(15); i++)
                {
                    string column1 = "IT0001050225";
                    string column2 = "ABC Fund";
                    string column3 = "EUR";
                    double column4 = Math.Round(rnd.NextDouble() * max, 2);
                    double column5 = Math.Round(rnd.NextDouble() * max, 2);
                    double column6 = Math.Round(rnd.NextDouble() * max, 2);
                    double column7 = Math.Round(rnd.NextDouble() * 100, 2);

                    BeanComponentElement item = new BeanComponentElement(column1,
                                                                         column2,
                                                                         column3,
                                                                         column4,
                                                                         column5,
                                                                         column6,
                                                                         column7);
                    subCompList.Add(item);
                }

                if (subCompList.Count != 0)
                {
                    BeanComponent subComp = new BeanComponent(componenteName[subIndex], subCompList);
                    Component.Add(subComp);
                }
            }

            return Component;
        }
    }
}
