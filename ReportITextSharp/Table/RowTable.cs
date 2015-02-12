using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportITextSharp.common;
using ReportITextSharp.data;
using System.Collections.Generic;

namespace ReportITextSharp.Table
{
    class ComposizioneDiDettaglioTable
    {
        public static void createTable(Document doc, PdfWriter writer)
        {

            List<BeanComponent> bean = TestData.getComposizioneDiDettaglioData();

            PdfPTable table = new PdfPTable(1);
            table.WidthPercentage = 100;
            table.SetWidths(new int[] { 455 });
            table.SpacingBefore = 10;

            // --------------   top shadow   -----------------
            PdfPCell cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowUp(writer);
            table.AddCell(cell);
            // ------------------------------------------------

            cell = new PdfPCell(new Phrase(" Component List", Common.FONT_TITLE_SECOND_LEVEL));
            cell.Colspan = table.NumberOfColumns;
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            cell.PaddingLeft = Common.PADDING_LEFT;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 35;
            table.AddCell(cell);



            // --------------   bottom shadow   -----------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowDown(writer);
            table.AddCell(cell);
            // ------------------------------------------------



            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.FixedHeight = 8;
            cell.BorderWidth = 0;
            table.AddCell(cell);

            doc.Add(table);





            table = new PdfPTable(7);
            table.WidthPercentage = 100;
            table.SetWidths(new int[] { 82, 121, 38, 60, 60, 60, 35 });

            table.HeaderRows = 5;
            table.TableEvent = new RepeatTableSplitEvent(writer, doc);



            // --------------   top shadow   -----------------
            cell = new PdfPCell(new Phrase(""));
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowUp(writer);
            table.AddCell(cell);
            // ------------------------------------------------



            cell = new PdfPCell(new Phrase(""));
            cell.Colspan = table.NumberOfColumns;
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
            cell.FixedHeight = 5;
            cell.PaddingLeft = 5;
            table.AddCell(cell);


            cell = new PdfPCell(new Phrase("Column 1", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
            cell.FixedHeight = 25;
            cell.PaddingLeft = 10;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Column 2", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = 1;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 25;
            cell.PaddingLeft = 10;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Column 3", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
            cell.HorizontalAlignment = 1;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = 1;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 25;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Column 4", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
            cell.HorizontalAlignment = 2;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = 1;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 25;
            cell.PaddingRight = 5;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Column 5", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
            cell.HorizontalAlignment = 2;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = 1;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 25;
            cell.PaddingRight = 5;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Column 6", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
            cell.HorizontalAlignment = 2;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderWidthLeft = 1;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 25;
            cell.PaddingRight = 5;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Col. 7", Common.FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT));
            cell.HorizontalAlignment = 1;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthLeft = 1;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
            cell.FixedHeight = 25;
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
            cell.FixedHeight = 5;
            cell.PaddingLeft = 5;
            table.AddCell(cell);


            // --------------   bottom shadow   -----------------
            cell = new PdfPCell(new Phrase(""));
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowDown(writer);
            table.AddCell(cell);
            // ------------------------------------------------



            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.BorderWidth = 0;
            cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
            cell.FixedHeight = 5;
            cell.PaddingLeft = 5;
            table.AddCell(cell);


            for (int i = 0; i < bean.Count; i++)
            {

                BeanComponent component = bean[i];

                if (i != 0)
                {
                    // --------------   top shadow   -----------------

                    cell = new PdfPCell();
                    cell.Colspan = table.NumberOfColumns;
                    cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
                    cell.BorderWidthTop = 0;
                    cell.BorderWidthBottom = 0;
                    cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
                    cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
                    cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
                    cell.CellEvent = new CellShadowUp(writer);
                    table.AddCell(cell);

                    // ------------------------------------------------
                }
                else
                {
                    // --------------   top shadow   -----------------
                    cell = new PdfPCell();
                    cell.Colspan = table.NumberOfColumns;
                    cell.BorderWidth = 0;
                    cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
                    cell.CellEvent = new CellShadowUp(writer);
                    table.AddCell(cell);
                    // ------------------------------------------------
                }

                cell = new PdfPCell(new Phrase(new Phrase("Component", Common.FONT_COMPONENT_BOLD)));
                cell.Colspan = 4;
                cell.HorizontalAlignment = 0;
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.BorderWidth = 0;
                cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
                cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_FIRST_LEVEL;
                cell.FixedHeight = 25;
                cell.PaddingLeft = Common.PADDING_LEFT;
                table.AddCell(cell);


                cell = new PdfPCell(new Phrase(component.total.ToString("N", Common.CULTURE_INFO_NUMBER_FORMAT), Common.FONT_COMPONENT_BOLD));
                cell.Colspan = 2;
                cell.HorizontalAlignment = 2;
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.BorderWidth = 0;
                cell.PaddingLeft = 5;
                table.AddCell(cell);

                cell = new PdfPCell();
                cell.HorizontalAlignment = 1;
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.BorderWidthTop = 0;
                cell.BorderWidthBottom = 0;
                cell.BorderWidthLeft = 1;
                cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
                cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_SECOND_LEVEL;
                cell.PaddingLeft = 5;
                table.AddCell(cell);


                // --------------   bottom shadow   -----------------

                cell = new PdfPCell();
                cell.Colspan = table.NumberOfColumns;
                cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
                cell.BorderWidthTop = 0;
                cell.BorderWidthBottom = 0;
                cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
                cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
                cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
                cell.CellEvent = new CellShadowDown(writer);
                table.AddCell(cell);

                // ------------------------------------------------



                for (int j = 0; j < component.elements.Count; j++)
                {
                    BeanComponentElement item = component.elements[j];
                   

                    cell = new PdfPCell(new Phrase(item.column1, Common.FONT_BODY_THIRD_LEVEL_DATA_BOLD));
                    cell.HorizontalAlignment = 0;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.BorderWidth = 0;
                    cell.BorderWidthLeft = Common.BORDER_WIDTH_LEFT;
                    cell.BorderColor = new BaseColor(148, 149, 153);
                    cell.BorderColorLeft = Common.BORDER_COLOR_LEFT_THIRD_LEVEL;
                    cell.FixedHeight = 25;
                    cell.PaddingLeft = 10;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(item.column2, Common.FONT_BODY_THIRD_LEVEL_DATA_LIGHT));
                    cell.HorizontalAlignment = 0;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.BorderWidth = 0;
                    cell.BorderWidthLeft = 1;
                    cell.BorderColor = new BaseColor(148, 149, 153);
                    cell.BorderColorLeft = new BaseColor(148, 149, 153);
                    cell.FixedHeight = 25;
                    cell.PaddingLeft = 5;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(item.column3, Common.FONT_BODY_THIRD_LEVEL_DATA_BOLD));
                    cell.HorizontalAlignment = 1;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.BorderWidth = 0;
                    cell.BorderWidthLeft = 1;
                    cell.BorderColor = new BaseColor(148, 149, 153);
                    cell.BorderColorLeft = new BaseColor(148, 149, 153);
                    cell.FixedHeight = 25;
                    cell.PaddingLeft = 5;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(item.column4.ToString("N", Common.CULTURE_INFO_NUMBER_FORMAT), Common.FONT_BODY_THIRD_LEVEL_DATA_LIGHT));
                    cell.HorizontalAlignment = 1;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.BorderWidth = 0;
                    cell.BorderWidthLeft = 1;
                    cell.BorderColor = new BaseColor(148, 149, 153);
                    cell.BorderColorLeft = new BaseColor(148, 149, 153);
                    cell.FixedHeight = 25;
                    cell.PaddingLeft = 5;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(item.column5.ToString("N", Common.CULTURE_INFO_NUMBER_FORMAT), Common.FONT_BODY_THIRD_LEVEL_DATA_LIGHT));
                    cell.HorizontalAlignment = 1;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.BorderWidth = 0;
                    cell.BorderWidthLeft = 1;
                    cell.BorderColor = new BaseColor(148, 149, 153);
                    cell.BorderColorLeft = new BaseColor(148, 149, 153);
                    cell.FixedHeight = 25;
                    cell.PaddingLeft = 5;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(item.column6.ToString("N", Common.CULTURE_INFO_NUMBER_FORMAT), Common.FONT_BODY_THIRD_LEVEL_DATA_BOLD));
                    cell.HorizontalAlignment = 1;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.BorderWidth = 0;
                    cell.BorderWidthLeft = 1;
                    cell.BorderColor = new BaseColor(148, 149, 153);
                    cell.BorderColorLeft = new BaseColor(148, 149, 153);
                    cell.FixedHeight = 25;
                    cell.PaddingLeft = 5;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(item.column7.ToString("N", Common.CULTURE_INFO_NUMBER_FORMAT), Common.FONT_BODY_THIRD_LEVEL_DATA_LIGHT));
                    cell.HorizontalAlignment = 1;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.BorderWidthTop = 0;
                    cell.BorderWidthBottom = 0;
                    cell.BorderWidthLeft = 1;
                    cell.BorderColor = Common.DEFAULT_BORDER_COLOR;
                    cell.BorderColorLeft = new BaseColor(148, 149, 153);
                    cell.FixedHeight = 25;
                    cell.PaddingLeft = 5;
                    table.AddCell(cell);
                }

            }

            //---------------------------------------------------------------------------------------------------------------


            // --------------   top shadow   -----------------
            cell = new PdfPCell();
            cell.Colspan = table.NumberOfColumns;
            cell.BorderWidth = 0;
            cell.FixedHeight = Common.FIXED_HEIGHT_SHADOW;
            cell.CellEvent = new CellShadowDown(writer);
            table.AddCell(cell);
            // ------------------------------------------------



            doc.Add(table);

        }
    }
}
