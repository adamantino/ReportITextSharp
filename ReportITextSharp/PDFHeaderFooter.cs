using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportITextSharp.common;
using System;
using System.Globalization;
using System.IO;

namespace ReportITextSharp
{
    public class PDFHeaderFooter : PdfPageEventHelper
    {

        // The template with the total number of pages.
        PdfTemplate total;

        // Write on top of document
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            //Creates the PdfTemplate that will hold the total number of pages.
            total = writer.DirectContent.CreateTemplate(30, 15);

            base.OnOpenDocument(writer, document);
        }

        // write on start of each page
        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);
        }

        // write on end of each page
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);


            //-------   HEADER   ------------------------------------------------------------------------------------------------

            PdfPTable table_logo = new PdfPTable(2);
            table_logo.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            table_logo.SetWidths(new float[] { 50, 50 });
            table_logo.LockedWidth = true;

            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            using (Stream inputImageStream = new FileStream(appRootDir + "/images/" + "logo_right.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
                image.ScaleToFit(new Rectangle(120, 42));

                PdfPCell cell = new PdfPCell(image);
                cell.FixedHeight = 42;
                cell.HorizontalAlignment = 0;
                cell.BorderWidth = 0;
                cell.BorderWidthRight = 1;
                cell.VerticalAlignment = PdfPCell.ALIGN_BOTTOM;
                cell.UseVariableBorders = true;
                cell.BorderColorRight = Common.VERTICAL_LINE_COLOR;
                table_logo.AddCell(cell);

            }


            using (Stream inputImageStream = new FileStream(appRootDir + "/images/" + "logo_left.png", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);

                PdfPCell cell = new PdfPCell(image, true);
                cell.FixedHeight = 42;
                cell.HorizontalAlignment = 2;
                cell.BorderWidth = 0;
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.UseVariableBorders = true;
 
                table_logo.AddCell(cell);
            }
            table_logo.WriteSelectedRows(0, -1, document.RightMargin, document.Top + 90, writer.DirectContent);



            //-------   FOOTER   ------------------------------------------------------------------------------------------------

            PdfPTable table_footer = new PdfPTable(3);
            table_footer.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            table_footer.SetWidths(new int[] { 75, 16, 9 });
            table_footer.LockedWidth = true;


            PdfPCell cell_footer = new PdfPCell();
            cell_footer.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell_footer.FixedHeight = 25;
            cell_footer.UseVariableBorders = true;
            cell_footer.BorderWidth = 0;
            cell_footer.BorderWidthRight = 1;
            cell_footer.BorderColorRight = Common.VERTICAL_LINE_COLOR;
            table_footer.AddCell(cell_footer);


            Phrase phrase_first = new Phrase("Pagina ", Common.FONT_FOOTER_PAGE);
            Phrase phrase_second = new Phrase(Convert.ToString(writer.PageNumber), Common.FONT_FOOTER_PAGE_NUMBER);
            Phrase phrase_third = new Phrase(" di", Common.FONT_FOOTER_PAGE);
            phrase_first.Add(phrase_second);
            phrase_first.Add(phrase_third);

            cell_footer = new PdfPCell(phrase_first);
            cell_footer.HorizontalAlignment = 2;
            cell_footer.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell_footer.UseVariableBorders = true;
            cell_footer.BorderWidth = 0;
            table_footer.AddCell(cell_footer);


            cell_footer = new PdfPCell(Image.GetInstance(total));
            cell_footer.HorizontalAlignment = 0;
            cell_footer.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell_footer.BorderWidth = 0;
            table_footer.AddCell(cell_footer);

            table_footer.WriteSelectedRows(0, -1, document.RightMargin, document.Bottom - document.BottomMargin + 110, writer.DirectContent);
           
        }




        //write on close of document
        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            //Fills out the total number of pages before the document is closed.
            ColumnText.ShowTextAligned(total, Element.ALIGN_LEFT, new Phrase(Convert.ToString(writer.PageNumber - 1), Common.FONT_FOOTER_PAGE_NUMBER), 0, 2, 0);

            base.OnCloseDocument(writer, document);
        }
    }
}
