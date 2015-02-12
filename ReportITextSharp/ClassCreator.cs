using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportITextSharp.Table;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportITextSharp
{
    class ClassCreator
    {

        // Define the margins
        private static readonly float HEADER_MARGIN = 42;
        private static readonly float FOOTER_MARGIN = 70;
        private static readonly float PAGE_MARGIN_LEFT = 70;
        private static readonly float PAGE_MARGIN_RIGHT = 70;
        private static readonly float PAGE_MARGIN_BOTTOM = 74 + FOOTER_MARGIN;
        private static readonly float PAGE_MARGIN_TOP = 100 + HEADER_MARGIN;

        // Define document format
        private static readonly iTextSharp.text.Rectangle PAGE_SIZE = PageSize.A4;

        public ClassCreator()
        {

            // Get the working directory path
            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

            // Create the FileStream for the output file
            FileStream fs = new FileStream(appRootDir + "/PDFs/" + "ReportITextSharp.pdf", FileMode.Create, FileAccess.Write, FileShare.None);

            // Create the document
            Document doc = new Document(PAGE_SIZE, PAGE_MARGIN_LEFT, PAGE_MARGIN_RIGHT, PAGE_MARGIN_TOP, PAGE_MARGIN_BOTTOM);

            // Setting Document properties
            doc.AddTitle("ReportITextSharp");
            doc.AddKeywords("iTextSharp 5.4.4");
            doc.AddAuthor("Stefano Ballerini");

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            // Header + Footer
            writer.PageEvent = new PDFHeaderFooter();

            //Open the document
            doc.Open();


            FrontPageHeader.createTable(doc, writer);

            DounghtChartTable.createTable(doc, writer);

            doc.NewPage();
            ComposizioneDiDettaglioTable.createTable(doc, writer);


            //Close the document
            doc.Close();

            //Open the pdf automatically
            System.Diagnostics.Process.Start(appRootDir + "/PDFs/" + "ReportITextSharp.pdf");

        }
    }
}
