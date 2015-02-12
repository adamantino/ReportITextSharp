using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportITextSharp.common;
using System;
using System.Globalization;

namespace ReportITextSharp.Table
{
    class FrontPageHeader
    {
        public static void createTable(Document doc, PdfWriter writer)
        {
            // Create the table - 2 columns
            PdfPTable table = new PdfPTable(3);

            // Setting table width
            table.TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin;

            // Setting single column width
            table.SetWidths(new int[] { 136, 319 - Common.FIXED_HEIGHT_SHADOW, Common.FIXED_HEIGHT_SHADOW });

            // lock the width
            table.LockedWidth = true;


            // --------------   top shadow   -----------------
            PdfPCell cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns-1;
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowUp(writer);
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowTopRightCorner(writer);
            table.AddCell(cell);
            // ------------------------------------------------


            // Create cell
            cell = new PdfPCell(new Phrase("Report ITextSharp", Common.FONT_DOCUMENT_TITLE));

            // Cell's properties
            cell.Colspan = table.NumberOfColumns-1;
            cell.HorizontalAlignment = 0;                               // 0=right, 1=center, 2=left
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT; ;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 1;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_FIRST_LEVEL;
            cell.BorderColorBottom = Common.BORDER_COLOR_LEFT_FIRST_LEVEL;
            cell.FixedHeight = 70;
            cell.PaddingLeft = Common.PADDING_LEFT;

            // Add the cell to the table
            table.AddCell(cell);


            // --------------   Right shadow   -----------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.CellEvent = new CellShadowRight(writer);
            table.AddCell(cell);
            // ------------------------------------------------



            cell = new PdfPCell(new Phrase("Generation date : ", Common.FONT_BODY_SECOND_LEVEL));
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_FIRST_LEVEL;
            cell.FixedHeight = 35;
            cell.PaddingLeft = Common.PADDING_LEFT;
            table.AddCell(cell);



            cell = new PdfPCell(new Phrase(DateTime.Now.ToString("d/M/yyyy", new CultureInfo("de-DE")), Common.FONT_BODY_SECOND_LEVEL));
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.PaddingLeft = Common.PADDING_LEFT;
            table.AddCell(cell);


            // --------------   Right shadow   -----------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.CellEvent = new CellShadowRight(writer);
            table.AddCell(cell);
            // ------------------------------------------------
            


            // --------------   bottom shadow   ---------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns-1;
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowDown(writer);
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowBottomRightCorner(writer);
            table.AddCell(cell);
            // ------------------------------------------------


            doc.Add(table);
        }
    }
}
