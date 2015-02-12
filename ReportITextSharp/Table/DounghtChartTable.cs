using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportITextSharp.chart;
using ReportITextSharp.common;
using ReportITextSharp.data;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReportITextSharp.Table
{
    class DounghtChartTable
    {

        public static void createTable(Document doc, PdfWriter writer){

            List<BeanDounghtChartElement> list = new List<BeanDounghtChartElement>();

            list.Add(new BeanDounghtChartElement("Element 1", 15.00, Color.FromArgb(23, 150, 114)));

            list.Add(new BeanDounghtChartElement("Element 2", 40.00, Color.FromArgb(81, 176, 149)));

            list.Add(new BeanDounghtChartElement("Element 3", 35.00, Color.FromArgb(139, 202, 184)));

            list.Add(new BeanDounghtChartElement("Element 4", 10.00, Color.FromArgb(193, 227, 218)));

            BeanDounghtChartData bean = new BeanDounghtChartData(list);







            PdfPTable table = new PdfPTable(6);
            table.WidthPercentage = 100;

            table.SetWidths(new int[] { 20, 60, 15, 158, 202 - Common.FIXED_HEIGHT_SHADOW, Common.FIXED_HEIGHT_SHADOW });

            table.DefaultCell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            table.DefaultCell.UseVariableBorders = true;


            // --------------   top shadow   -----------------
            PdfPCell cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns - 1;
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


            cell = new PdfPCell(new Phrase(" Dounght Chart", Common.FONT_TITLE_SECOND_LEVEL));
            cell.Colspan = table.NumberOfColumns-1;
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthRight = 0;
            cell.PaddingLeft = Common.PADDING_LEFT;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 35;
            table.AddCell(cell);

            // --------------   Right shadow   -----------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.CellEvent = new CellShadowRight(writer);
            table.AddCell(cell);
            // ------------------------------------------------



            // --------------   bottom shadow   -----------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns-1;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowDown(writer);
            table.AddCell(cell);
            // ------------------------------------------------
            // --------------   Right shadow   -----------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.CellEvent = new CellShadowRight(writer);
            table.AddCell(cell);
            // ------------------------------------------------


            // first 4 empty cells (height 60)
            cell = new PdfPCell();
            cell.Colspan = 4;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.FixedHeight = 60;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
            table.AddCell(cell);





            var chartImage = new MemoryStream();
            DougnutChart.getDougnutChart(bean).SaveImage(chartImage, ChartImageFormat.Png);
            iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());


            cell = new PdfPCell(chart_image, true);
            cell.BorderWidthBottom = 0;
            cell.BorderWidthTop = 0;
            cell.BorderWidthLeft = 0;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
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
            cell.Colspan = table.NumberOfColumns - 1;
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
