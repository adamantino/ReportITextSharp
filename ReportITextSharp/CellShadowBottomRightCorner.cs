using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ReportITextSharp
{
    class CellShadowBottomRightCorner : IPdfPCellEvent
    {
        //Holds pointer to main PdfWriter object
        private PdfWriter w;

        public CellShadowBottomRightCorner(PdfWriter w)
        {
            this.w = w;
        }

        public void CellLayout(PdfPCell cell, Rectangle position, PdfContentByte[] canvases)
        {
            //Create a shading object with cell-specific coords
            PdfShading shading = PdfShading.SimpleAxial(w, position.Left, position.Top, position.Right - position.Width/2, position.Bottom + position.Height/2, new BaseColor(225, 225, 225), BaseColor.WHITE);

            //Create a pattern from our shading object
            PdfShadingPattern pattern = new PdfShadingPattern(shading);

            //Create a color from our patter
            ShadingColor color = new ShadingColor(pattern);

            //Get the background canvas. NOTE, If using an older version of iTextSharp (4.x) you might need to get the canvas in a different way
            PdfContentByte cb = canvases[PdfPTable.BACKGROUNDCANVAS];

            //Set the background color of the given rectable to our shading pattern
            position.BackgroundColor = color;

            //Fill the rectangle
            cb.Rectangle(position);
        }
    }
}
