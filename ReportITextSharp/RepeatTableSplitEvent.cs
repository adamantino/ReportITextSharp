using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.events;
using ReportITextSharp.common;
using System;
using System.IO;

namespace ReportITextSharp
{
    class RepeatTableSplitEvent : PdfPTableEventForwarder
    {
        Document document;
        PdfWriter writer;

        private bool FirstSplit = true;

        public RepeatTableSplitEvent(PdfWriter writer, Document doc)
        {
            this.document = doc;
            this.writer = writer;
        }

        public override void TableLayout(PdfPTable table, float[][] widths, float[] heights, int headerRows, int rowStart, PdfContentByte[] canvases)
        {
            table.GetRow(0);
            table.GetRow(0).GetCells();
            PdfPCell p = table.GetRow(0).GetCells()[0];

            if (!(ReferenceEquals(table.GetRow(0).GetCells()[0].Phrase, null)))
            {
                if(!FirstSplit)
                {

                    PdfPTable table_arrow = new PdfPTable(2);
                    table_arrow.TotalWidth = 200;
                    table_arrow.SetWidths(new float[] { 20, 80 });

                    string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
                    using (Stream inputImageStream = new FileStream(appRootDir + "/images/" + "arrow_right.png", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
                        image.ScaleToFit(new Rectangle(32, 17));

                        PdfPCell cell = new PdfPCell(image);
                        cell.FixedHeight = 17;
                        cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                        cell.BorderWidth = 0;
                        table_arrow.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Previous Page", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
                        cell.BorderWidth = 0;
                        cell.PaddingLeft = 2;
                        cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                        table_arrow.AddCell(cell);

                        table_arrow.WriteSelectedRows(0, -1, document.RightMargin, document.Top + 30, writer.DirectContent);
                    }
                }
            }

            FirstSplit = false;
        }

        public override void SplitTable(PdfPTable table)
        {

        }

        public override void AfterSplitTable(PdfPTable table, PdfPRow startRow, int startIdx)
        {


            //table.Rows.Insert(startIdx - 1, startRow);


            PdfPTable table_arrow = new PdfPTable(2);
            table_arrow.TotalWidth = 200;
            table_arrow.SetWidths(new float[] { 84, 16 });

            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            using (Stream inputImageStream = new FileStream(appRootDir + "/images/" + "arrow_right.png", FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                PdfPCell cell = new PdfPCell(new Phrase("Next Page", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
                cell.BorderWidth = 0;
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = 2;
                cell.PaddingRight = 10;
                table_arrow.AddCell(cell);


                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
                image.ScaleToFit(new Rectangle(32, 17));

                cell = new PdfPCell(image);
                cell.FixedHeight = 17;
                cell.HorizontalAlignment = 2;
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.BorderWidth = 0;
                table_arrow.AddCell(cell);

                table_arrow.WriteSelectedRows(0, -1, document.Right - 200, document.Bottom, writer.DirectContent);
            }

        }

    }
}
