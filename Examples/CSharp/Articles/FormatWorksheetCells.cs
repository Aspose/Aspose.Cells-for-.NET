using System;
using System.Drawing;
using Aspose.Cells;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    // ExStart:1
    /// <summary>
    /// AsposeFormatWorksheet
    /// Use Aspose.Cells to perform the task
    /// </summary>
    class FormatWorksheetCells
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Run()
        {
            string filename = RunExamples.Get_OutputDirectory() + "outputFormatWorksheetCells.xlsx";

            CreateSalesReport(filename);

            Console.WriteLine("FormatWorksheetCells executed successfully.\r\n");
        }

        private static void CreateSalesReport(string filename)
        {
            // Create a new Workbook.
            Workbook workbook = new Workbook();

            /*
             * Note: Since Excel color palette has 56 colors on it.
             * The colors are indexed 0-55.
             * Please check: http:// Www.aspose.com/Products/Aspose.Cells/Api/Aspose.Cells.Workbook.ChangePalette.html
             * If a color is not present on the palette, we have to add it
             * To the palette, so that we may use.
             * Add a few custom colors to the palette.
            */
            workbook.ChangePalette(Color.FromArgb(155, 204, 255), 55);
            workbook.ChangePalette(Color.FromArgb(0, 51, 105), 54);
            workbook.ChangePalette(Color.FromArgb(250, 250, 200), 53);
            workbook.ChangePalette(Color.FromArgb(124, 199, 72), 52);

            CreateReportData(workbook);
            CreateCellsFormatting(workbook);

            // Get the first worksheet in the book.
            Worksheet worksheet = workbook.Worksheets[0];
            // Name the worksheet.
            worksheet.Name = "Sales Report";
            // Save the excel file.
            workbook.Save(filename);
        }

        private static void CreateReportData(Workbook workbook)
        {
            // Obtain the cells of the first worksheet.
            Cells cells = workbook.Worksheets[0].Cells;

            // Input the title on B1 cell.
            cells["B1"].PutValue("Western Product Sales 2006");

            // Insert some column headings in the second row.
            Cell cell = cells["B2"];
            cell.PutValue("January");
            cell = cells["C2"];
            cell.PutValue("February");
            cell = cells["D2"];
            cell.PutValue("March");
            cell = cells["E2"];
            cell.PutValue("April");
            cell = cells["F2"];
            cell.PutValue("May");
            cell = cells["G2"];
            cell.PutValue("June");
            cell = cells["H2"];
            cell.PutValue("July");
            cell = cells["I2"];
            cell.PutValue("August");
            cell = cells["J2"];
            cell.PutValue("September");
            cell = cells["K2"];
            cell.PutValue("October");
            cell = cells["L2"];
            cell.PutValue("November");
            cell = cells["M2"];
            cell.PutValue("December");
            cell = cells["N2"];
            cell.PutValue("Total");

            // Insert product names.
            cells["A3"].PutValue("Biscuits");
            cells["A4"].PutValue("Coffee");
            cells["A5"].PutValue("Tofu");
            cells["A6"].PutValue("Ikura");
            cells["A7"].PutValue("Choclade");
            cells["A8"].PutValue("Maxilaku");
            cells["A9"].PutValue("Scones");
            cells["A10"].PutValue("Sauce");
            cells["A11"].PutValue("Syrup");
            cells["A12"].PutValue("Spegesild");
            cells["A13"].PutValue("Filo Mix");
            cells["A14"].PutValue("Pears");
            cells["A15"].PutValue("Konbu");
            cells["A16"].PutValue("Kaviar");
            cells["A17"].PutValue("Zaanse");
            cells["A18"].PutValue("Cabrales");
            cells["A19"].PutValue("Gnocchi");
            cells["A20"].PutValue("Wimmers");
            cells["A21"].PutValue("Breads");
            cells["A22"].PutValue("Lager");
            cells["A23"].PutValue("Gravad");
            cells["A24"].PutValue("Telino");
            cells["A25"].PutValue("Pavlova");
            cells["A26"].PutValue("Total");

            // Input porduct sales data (B3:M25).
            cells["B3"].PutValue(5000);
            cells["C3"].PutValue(4500);
            cells["D3"].PutValue(6010);
            cells["E3"].PutValue(7230);
            cells["F3"].PutValue(5400);
            cells["G3"].PutValue(5030);
            cells["H3"].PutValue(3000);
            cells["I3"].PutValue(6000);
            cells["J3"].PutValue(9000);
            cells["K3"].PutValue(3300);
            cells["L3"].PutValue(2500);
            cells["M3"].PutValue(5510);

            cells["B4"].PutValue(4000);
            cells["C4"].PutValue(2500);
            cells["D4"].PutValue(6000);
            cells["E4"].PutValue(5300);
            cells["F4"].PutValue(7400);
            cells["G4"].PutValue(7030);
            cells["H4"].PutValue(4000);
            cells["I4"].PutValue(4000);
            cells["J4"].PutValue(5500);
            cells["K4"].PutValue(4500);
            cells["L4"].PutValue(2500);
            cells["M4"].PutValue(2510);

            cells["B5"].PutValue(2000);
            cells["C5"].PutValue(1500);
            cells["D5"].PutValue(3000);
            cells["E5"].PutValue(2500);
            cells["F5"].PutValue(3400);
            cells["G5"].PutValue(4030);
            cells["H5"].PutValue(2000);
            cells["I5"].PutValue(2000);
            cells["J5"].PutValue(1500);
            cells["K5"].PutValue(2200);
            cells["L5"].PutValue(2100);
            cells["M5"].PutValue(2310);

            cells["B6"].PutValue(1000);
            cells["C6"].PutValue(1300);
            cells["D6"].PutValue(2000);
            cells["E6"].PutValue(2600);
            cells["F6"].PutValue(5400);
            cells["G6"].PutValue(2030);
            cells["H6"].PutValue(2100);
            cells["I6"].PutValue(4000);
            cells["J6"].PutValue(6500);
            cells["K6"].PutValue(5600);
            cells["L6"].PutValue(3300);
            cells["M6"].PutValue(5110);

            cells["B7"].PutValue(3000);
            cells["C7"].PutValue(3500);
            cells["D7"].PutValue(1000);
            cells["E7"].PutValue(4500);
            cells["F7"].PutValue(5400);
            cells["G7"].PutValue(2030);
            cells["H7"].PutValue(3000);
            cells["I7"].PutValue(3000);
            cells["J7"].PutValue(4500);
            cells["K7"].PutValue(6000);
            cells["L7"].PutValue(3000);
            cells["M7"].PutValue(3000);

            cells["B8"].PutValue(5000);
            cells["C8"].PutValue(5500);
            cells["D8"].PutValue(5000);
            cells["E8"].PutValue(5500);
            cells["F8"].PutValue(5400);
            cells["G8"].PutValue(5030);
            cells["H8"].PutValue(5000);
            cells["I8"].PutValue(2500);
            cells["J8"].PutValue(5500);
            cells["K8"].PutValue(5200);
            cells["L8"].PutValue(5500);
            cells["M8"].PutValue(2510);

            cells["B9"].PutValue(4100);
            cells["C9"].PutValue(1500);
            cells["D9"].PutValue(1000);
            cells["E9"].PutValue(2300);
            cells["F9"].PutValue(3300);
            cells["G9"].PutValue(4030);
            cells["H9"].PutValue(5000);
            cells["I9"].PutValue(6000);
            cells["J9"].PutValue(3500);
            cells["K9"].PutValue(4300);
            cells["L9"].PutValue(2300);
            cells["M9"].PutValue(2110);

            cells["B10"].PutValue(2000);
            cells["C10"].PutValue(2300);
            cells["D10"].PutValue(3000);
            cells["E10"].PutValue(3300);
            cells["F10"].PutValue(3400);
            cells["G10"].PutValue(3030);
            cells["H10"].PutValue(3000);
            cells["I10"].PutValue(3000);
            cells["J10"].PutValue(3500);
            cells["K10"].PutValue(3500);
            cells["L10"].PutValue(3500);
            cells["M10"].PutValue(3510);

            cells["B11"].PutValue(4400);
            cells["C11"].PutValue(4500);
            cells["D11"].PutValue(4000);
            cells["E11"].PutValue(4300);
            cells["F11"].PutValue(4400);
            cells["G11"].PutValue(4030);
            cells["H11"].PutValue(5000);
            cells["I11"].PutValue(5000);
            cells["J11"].PutValue(4500);
            cells["K11"].PutValue(4400);
            cells["L11"].PutValue(4400);
            cells["M11"].PutValue(4510);

            cells["B12"].PutValue(2000);
            cells["C12"].PutValue(1500);
            cells["D12"].PutValue(3000);
            cells["E12"].PutValue(2300);
            cells["F12"].PutValue(3400);
            cells["G12"].PutValue(3030);
            cells["H12"].PutValue(3000);
            cells["I12"].PutValue(3000);
            cells["J12"].PutValue(2500);
            cells["K12"].PutValue(2500);
            cells["L12"].PutValue(1500);
            cells["M12"].PutValue(5110);

            cells["B13"].PutValue(4000);
            cells["C13"].PutValue(1400);
            cells["D13"].PutValue(1400);
            cells["E13"].PutValue(3300);
            cells["F13"].PutValue(3300);
            cells["G13"].PutValue(3730);
            cells["H13"].PutValue(3800);
            cells["I13"].PutValue(3600);
            cells["J13"].PutValue(2600);
            cells["K13"].PutValue(4600);
            cells["L13"].PutValue(1400);
            cells["M13"].PutValue(2660);

            cells["B14"].PutValue(3000);
            cells["C14"].PutValue(3500);
            cells["D14"].PutValue(3333);
            cells["E14"].PutValue(2330);
            cells["F14"].PutValue(3430);
            cells["G14"].PutValue(3040);
            cells["H14"].PutValue(3040);
            cells["I14"].PutValue(3030);
            cells["J14"].PutValue(1509);
            cells["K14"].PutValue(4503);
            cells["L14"].PutValue(1503);
            cells["M14"].PutValue(3113);

            cells["B15"].PutValue(2010);
            cells["C15"].PutValue(1520);
            cells["D15"].PutValue(3030);
            cells["E15"].PutValue(2320);
            cells["F15"].PutValue(3410);
            cells["G15"].PutValue(3000);
            cells["H15"].PutValue(3000);
            cells["I15"].PutValue(3020);
            cells["J15"].PutValue(2520);
            cells["K15"].PutValue(2520);
            cells["L15"].PutValue(1520);
            cells["M15"].PutValue(5120);

            cells["B16"].PutValue(2220);
            cells["C16"].PutValue(1200);
            cells["D16"].PutValue(3220);
            cells["E16"].PutValue(1320);
            cells["F16"].PutValue(1400);
            cells["G16"].PutValue(1030);
            cells["H16"].PutValue(3200);
            cells["I16"].PutValue(3020);
            cells["J16"].PutValue(2100);
            cells["K16"].PutValue(2100);
            cells["L16"].PutValue(1100);
            cells["M16"].PutValue(5210);

            cells["B17"].PutValue(1444);
            cells["C17"].PutValue(1540);
            cells["D17"].PutValue(3040);
            cells["E17"].PutValue(2340);
            cells["F17"].PutValue(1440);
            cells["G17"].PutValue(1030);
            cells["H17"].PutValue(3000);
            cells["I17"].PutValue(4000);
            cells["J17"].PutValue(4500);
            cells["K17"].PutValue(2500);
            cells["L17"].PutValue(4500);
            cells["M17"].PutValue(5550);

            cells["B18"].PutValue(4000);
            cells["C18"].PutValue(5500);
            cells["D18"].PutValue(3000);
            cells["E18"].PutValue(3300);
            cells["F18"].PutValue(3330);
            cells["G18"].PutValue(5330);
            cells["H18"].PutValue(3400);
            cells["I18"].PutValue(3040);
            cells["J18"].PutValue(2540);
            cells["K18"].PutValue(4500);
            cells["L18"].PutValue(4500);
            cells["M18"].PutValue(2110);

            cells["B19"].PutValue(2000);
            cells["C19"].PutValue(2500);
            cells["D19"].PutValue(3200);
            cells["E19"].PutValue(3200);
            cells["F19"].PutValue(2330);
            cells["G19"].PutValue(5230);
            cells["H19"].PutValue(2400);
            cells["I19"].PutValue(3240);
            cells["J19"].PutValue(2240);
            cells["K19"].PutValue(4300);
            cells["L19"].PutValue(4100);
            cells["M19"].PutValue(2310);


            cells["B20"].PutValue(7000);
            cells["C20"].PutValue(8500);
            cells["D20"].PutValue(8000);
            cells["E20"].PutValue(5300);
            cells["F20"].PutValue(6330);
            cells["G20"].PutValue(7330);
            cells["H20"].PutValue(3600);
            cells["I20"].PutValue(3940);
            cells["J20"].PutValue(2940);
            cells["K20"].PutValue(4600);
            cells["L20"].PutValue(6500);
            cells["M20"].PutValue(8710);

            cells["B21"].PutValue(4000);
            cells["C21"].PutValue(4500);
            cells["D21"].PutValue(2000);
            cells["E21"].PutValue(2200);
            cells["F21"].PutValue(2000);
            cells["G21"].PutValue(3000);
            cells["H21"].PutValue(3000);
            cells["I21"].PutValue(3000);
            cells["J21"].PutValue(4330);
            cells["K21"].PutValue(4420);
            cells["L21"].PutValue(4500);
            cells["M21"].PutValue(1330);

            cells["B22"].PutValue(2050);
            cells["C22"].PutValue(3520);
            cells["D22"].PutValue(1030);
            cells["E22"].PutValue(2000);
            cells["F22"].PutValue(3000);
            cells["G22"].PutValue(2000);
            cells["H22"].PutValue(2010);
            cells["I22"].PutValue(2210);
            cells["J22"].PutValue(2230);
            cells["K22"].PutValue(4240);
            cells["L22"].PutValue(3330);
            cells["M22"].PutValue(2000);

            cells["B23"].PutValue(1222);
            cells["C23"].PutValue(3000);
            cells["D23"].PutValue(3020);
            cells["E23"].PutValue(2770);
            cells["F23"].PutValue(3011);
            cells["G23"].PutValue(2000);
            cells["H23"].PutValue(6000);
            cells["I23"].PutValue(9000);
            cells["J23"].PutValue(4000);
            cells["K23"].PutValue(2000);
            cells["L23"].PutValue(5000);
            cells["M23"].PutValue(6333);

            cells["B24"].PutValue(1000);
            cells["C24"].PutValue(2000);
            cells["D24"].PutValue(1000);
            cells["E24"].PutValue(1300);
            cells["F24"].PutValue(1330);
            cells["G24"].PutValue(1390);
            cells["H24"].PutValue(1600);
            cells["I24"].PutValue(1900);
            cells["J24"].PutValue(1400);
            cells["K24"].PutValue(1650);
            cells["L24"].PutValue(1520);
            cells["M24"].PutValue(1910);

            cells["B25"].PutValue(2000);
            cells["C25"].PutValue(6600);
            cells["D25"].PutValue(3300);
            cells["E25"].PutValue(8300);
            cells["F25"].PutValue(2000);
            cells["G25"].PutValue(3000);
            cells["H25"].PutValue(6000);
            cells["I25"].PutValue(4000);
            cells["J25"].PutValue(7000);
            cells["K25"].PutValue(2000);
            cells["L25"].PutValue(5000);
            cells["M25"].PutValue(5500);

            // Add Monthwise Summary formulas.
            cells["B26"].Formula = "=SUM(B3:B25)";
            cells["C26"].Formula = "=SUM(C3:C25)";
            cells["D26"].Formula = "=SUM(D3:D25)";
            cells["E26"].Formula = "=SUM(E3:E25)";
            cells["F26"].Formula = "=SUM(F3:F25)";
            cells["G26"].Formula = "=SUM(G3:G25)";
            cells["H26"].Formula = "=SUM(H3:H25)";
            cells["I26"].Formula = "=SUM(I3:I25)";
            cells["J26"].Formula = "=SUM(J3:J25)";
            cells["K26"].Formula = "=SUM(K3:K25)";
            cells["L26"].Formula = "=SUM(L3:L25)";
            cells["M26"].Formula = "=SUM(M3:M25)";

            // Add Productwise Summary formulas.
            cells["N3"].Formula = "=SUM(B3:M3)";
            cells["N4"].Formula = "=SUM(B4:M4)";
            cells["N5"].Formula = "=SUM(B5:M5)";
            cells["N6"].Formula = "=SUM(B6:M6)";
            cells["N7"].Formula = "=SUM(B7:M7)";
            cells["N8"].Formula = "=SUM(B8:M8)";
            cells["N9"].Formula = "=SUM(B9:M9)";
            cells["N10"].Formula = "=SUM(B10:M10)";
            cells["N11"].Formula = "=SUM(B11:M11)";
            cells["N12"].Formula = "=SUM(B12:M12)";
            cells["N13"].Formula = "=SUM(B13:M13)";
            cells["N14"].Formula = "=SUM(B14:M14)";
            cells["N15"].Formula = "=SUM(B15:M15)";
            cells["N16"].Formula = "=SUM(B16:M16)";
            cells["N17"].Formula = "=SUM(B17:M17)";
            cells["N18"].Formula = "=SUM(B18:M18)";
            cells["N19"].Formula = "=SUM(B19:M19)";
            cells["N20"].Formula = "=SUM(B20:M20)";
            cells["N21"].Formula = "=SUM(B21:M21)";
            cells["N22"].Formula = "=SUM(B22:M22)";
            cells["N23"].Formula = "=SUM(B23:M23)";
            cells["N24"].Formula = "=SUM(B24:M24)";
            cells["N25"].Formula = "=SUM(B25:M25)";
            // Add Grand Total.
            cells["N26"].Formula = "=SUM(N3:N25)";
        }

        private static void CreateCellsFormatting(Workbook workbook)
        {

            // Define a style object adding a new style to the collection list.
            Style stl0 = workbook.CreateStyle();

            // Set a custom shading color of the cells.
            stl0.ForegroundColor = Color.FromArgb(155, 204, 255);
            stl0.Pattern = BackgroundType.Solid;
            stl0.Font.Name = "Trebuchet MS";
            stl0.Font.Size = 18;
            stl0.Font.Color = Color.Maroon;
            stl0.Font.IsBold = true;
            stl0.Font.IsItalic = true;

            // Define a style flag struct.
            StyleFlag flag = new StyleFlag();
            flag.CellShading = true;
            flag.FontName = true;
            flag.FontSize = true;
            flag.FontColor = true;
            flag.FontBold = true;
            flag.FontItalic = true;

            // Get the first row in the first worksheet.
            Row row = workbook.Worksheets[0].Cells.Rows[0];

            // Apply the style to it.
            row.ApplyStyle(stl0, flag);

            // Obtain the cells of the first worksheet.
            Cells cells = workbook.Worksheets[0].Cells;

            // Set the height of the first row.
            cells.SetRowHeight(0, 30);

            // Define a style object adding a new style to the collection list.
            Style stl1 = workbook.CreateStyle();

            // Set the rotation angle of the text.
            stl1.RotationAngle = 45;

            // Set the custom fill color of the cells.
            stl1.ForegroundColor = Color.FromArgb(0, 51, 105);
            stl1.Pattern = BackgroundType.Solid;
            stl1.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            stl1.Borders[BorderType.LeftBorder].Color = Color.White;
            stl1.HorizontalAlignment = TextAlignmentType.Center;
            stl1.VerticalAlignment = TextAlignmentType.Center;
            stl1.Font.Name = "Times New Roman";
            stl1.Font.Size = 10;
            stl1.Font.Color = Color.White;
            stl1.Font.IsBold = true;

            // Set a style flag struct.
            flag = new StyleFlag();
            flag.LeftBorder = true;
            flag.Rotation = true;
            flag.CellShading = true;
            flag.HorizontalAlignment = true;
            flag.VerticalAlignment = true;
            flag.FontName = true;
            flag.FontSize = true;
            flag.FontColor = true;
            flag.FontBold = true;
            row = workbook.Worksheets[0].Cells.Rows[1];

            // Apply the style to it.
            row.ApplyStyle(stl1, flag);

            // Set the height of the second row.
            cells.SetRowHeight(1, 48);

            // Define a style object adding a new style to the collection list.
            Style stl2 = workbook.CreateStyle();

            // Set the custom cell shading color.
            stl2.ForegroundColor = Color.FromArgb(155, 204, 255);
            stl2.Pattern = BackgroundType.Solid;
            stl2.Font.Name = "Trebuchet MS";
            stl2.Font.Color = Color.Maroon;
            stl2.Font.Size = 10;
            flag = new StyleFlag();
            flag.CellShading = true;
            flag.FontName = true;
            flag.FontColor = true;
            flag.FontSize = true;

            // Get the first column in the first worksheet.
            Column col = workbook.Worksheets[0].Cells.Columns[0];

            // Apply the style to it.
            col.ApplyStyle(stl2, flag);

            // Define a style object adding a new style to the collection list.
            Style stl3 = workbook.CreateStyle();

            // Set the custom cell filling color.
            stl3.ForegroundColor = Color.FromArgb(124, 199, 72);
            stl3.Pattern = BackgroundType.Solid;
            cells["A2"].SetStyle(stl3);

            // Define a style object adding a new style to the collection list.
            Style stl4 = workbook.CreateStyle();

            // Set the custom font text color.
            stl4.Font.Color = Color.FromArgb(0, 51, 105);
            stl4.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
            stl4.Borders[BorderType.BottomBorder].Color = Color.FromArgb(124, 199, 72);
            stl4.ForegroundColor = Color.White;
            stl4.Pattern = BackgroundType.Solid;

            // Set custom number format.
            stl4.Custom = "$#,##0.0";

            // Set a style flag struct.
            flag = new StyleFlag();
            flag.FontColor = true;
            flag.CellShading = true;
            flag.NumberFormat = true;
            flag.BottomBorder = true;

            // Define a style object adding a new style to the collection list.
            Style stl5 = workbook.CreateStyle();
            stl5.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
            stl5.Borders[BorderType.BottomBorder].Color = Color.FromArgb(124, 199, 72);
            stl5.ForegroundColor = Color.FromArgb(250, 250, 200);
            stl5.Pattern = BackgroundType.Solid;

            // Set custom number format.
            stl5.Custom = "$#,##0.0";
            stl5.Font.Color = Color.Maroon;

            // Create a named range of cells (B3:M25)in the first worksheet.
            Range range = workbook.Worksheets[0].Cells.CreateRange("B3", "M25");

            // Name the range.
            range.Name = "MyRange";

            // Apply the style to cells in the named range.
            range.ApplyStyle(stl4, flag);

            // Apply different style to alternative rows in the range.
            for (int i = 0; i <= 22; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i % 2 == 0)
                    {
                        range[i, j].SetStyle(stl5);
                    }
                }
            }

            // Define a style object adding a new style to the collection list.
            Style stl6 = workbook.CreateStyle();

            // Set the custom fill color of the cells.
            stl6.ForegroundColor = Color.FromArgb(0, 51, 105);
            stl6.Pattern = BackgroundType.Solid;
            stl6.Font.Name = "Arial";
            stl6.Font.Size = 10;
            stl6.Font.Color = Color.White;
            stl6.Font.IsBold = true;

            // Set the custom number format.
            stl6.Custom = "$#,##0.0";

            // Set the style flag struct.
            flag = new StyleFlag();
            flag.CellShading = true;
            flag.FontName = true;
            flag.FontSize = true;
            flag.FontColor = true;
            flag.FontBold = true;
            flag.NumberFormat = true;

            // Get the 26th row in the first worksheet which produces totals.
            row = workbook.Worksheets[0].Cells.Rows[25];

            // Apply the style to it.
            row.ApplyStyle(stl6, flag);

            // Now apply this style to those cells (N3:N25) which has productwise sales totals.
            for (int i = 2; i < 25; i++)
            {
                cells[i, 13].SetStyle(stl6);
            }

            // Set N column's width to fit the contents.
            workbook.Worksheets[0].Cells.SetColumnWidth(13, 9.33);
        }
    }
    // ExEnd:1
}