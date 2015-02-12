using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportITextSharp.common
{
    class Common
    {
        private static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

        //------  Colors
        public static BaseColor VERTICAL_LINE_COLOR = new BaseColor(148, 149, 153);

        //------  Fonts
        private static string FONT_FRUTIGER_LTStd_BOLD_BF_PATH = appRootDir + "\\font\\FrutigerLTStd\\" + "FrutigerLTStd-Bold.otf";
        public static string  FONT_FRUTIGER_LTStd_ROMAN_BF_PATH = appRootDir + "\\font\\FrutigerLTStd\\" + "FrutigerLTStd-Roman.otf";
        public static string FONT_FRUTIGER_LTStd_LIGHT_BF_PATH = appRootDir + "/font/FrutigerLTStd/" + "FrutigerLTStd-Light.otf";
        public static string FONT_FRUTIGER_LTStd_LIGHT_ITALIC_BF_PATH = appRootDir + "/font/FrutigerLTStd/" + "FrutigerLTStd-LightItalic.otf";

        private static BaseFont FONT_FRUTIGER_LTStd_BOLD_BF = BaseFont.CreateFont(FONT_FRUTIGER_LTStd_BOLD_BF_PATH, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private static BaseFont FONT_FRUTIGER_LTStd_LIGHT_BF = BaseFont.CreateFont(FONT_FRUTIGER_LTStd_LIGHT_BF_PATH, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private static BaseFont FONT_FRUTIGER_LTStd_ROMAN_BF = BaseFont.CreateFont(FONT_FRUTIGER_LTStd_ROMAN_BF_PATH, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private static BaseFont FONT_FRUTIGER_LTStd_LIGHT_ITALIC_BF = BaseFont.CreateFont(FONT_FRUTIGER_LTStd_LIGHT_ITALIC_BF_PATH, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

        public static iTextSharp.text.Font FONT_DOCUMENT_TITLE = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_BOLD_BF, 18, 0, BaseColor.BLACK);
        public static iTextSharp.text.Font FONT_BODY_SECOND_LEVEL = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_ROMAN_BF, 11, 0, BaseColor.BLACK);
        public static iTextSharp.text.Font FONT_BODY_SECOND_LEVEL_BOLD = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_BOLD_BF, 11, 0, BaseColor.BLACK);

        public static iTextSharp.text.Font FONT_TITLE_SECOND_LEVEL = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_BOLD_BF, 12, 0, BaseColor.BLACK);
        public static iTextSharp.text.Font FONT_HEADER_SECOND_LEVEL_GRAY_LIGHT = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_LIGHT_BF, 8, 0, BaseColor.GRAY);
        public static iTextSharp.text.Font FONT_COMPONENT_BOLD = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_BOLD_BF, 9, 0, BaseColor.BLACK);
        public static iTextSharp.text.Font FONT_BODY_THIRD_LEVEL_DATA_BOLD = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_BOLD_BF, 8, 0, BaseColor.BLACK);
        public static iTextSharp.text.Font FONT_BODY_THIRD_LEVEL_DATA_LIGHT = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_LIGHT_BF, 8, 0, BaseColor.BLACK);

        public static iTextSharp.text.Font FONT_FOOTER_PAGE = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_LIGHT_BF, 12, 0, BaseColor.BLACK);
        public static iTextSharp.text.Font FONT_FOOTER_PAGE_NUMBER = new iTextSharp.text.Font(FONT_FRUTIGER_LTStd_BOLD_BF, 12, 0, BaseColor.BLACK);


        //------  Table
        public static BaseColor DEFAULT_BORDER_COLOR = new BaseColor(225, 225, 225);
        public static BaseColor BORDER_COLOR_LEFT_FIRST_LEVEL = new BaseColor(23, 150, 114);
        public static BaseColor BORDER_COLOR_LEFT_SECOND_LEVEL = new BaseColor(81, 176, 149);
        public static BaseColor BORDER_COLOR_LEFT_THIRD_LEVEL = new BaseColor(139, 202, 184);

        public static CultureInfo CULTURE_INFO_NUMBER_FORMAT = new CultureInfo("it-IT");
       

            //------  Cell
        public static int FIXED_HEIGHT_SHADOW = 5;
        public static int BORDER_WIDTH_LEFT = 6;
        public static int PADDING_LEFT = 20;
    }
}
