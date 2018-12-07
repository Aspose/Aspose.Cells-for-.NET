﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class TotalsInOtherLanguages
    {
        public static void Run()
        {
            //Source directory
            string sourceDir = RunExamples.Get_SourceDirectory();

            //Output directory
            string outputDir = RunExamples.Get_OutputDirectory();

            // Load your source workbook
            Workbook wb = new Workbook(sourceDir + "sampleTotalsInOtherLanguages.xlsx");

            // Set the glorbalization setting to change subtotal and grand total names
            GlobalizationSettings gsi = new GlobalizationSettingsImp();
            wb.Settings.GlobalizationSettings = gsi;

            // Access first worksheet
            Worksheet ws = wb.Worksheets[0];

            // Apply subtotal on A1:B10
            CellArea ca = CellArea.CreateCellArea("A1", "B10");
            ws.Cells.Subtotal(ca, 0, ConsolidationFunction.Sum, new int[] { 2, 3, 4 });

            // Set the width of the first column
            ws.Cells.SetColumnWidth(0, 40);

            // Save the output excel file
            wb.Save(outputDir + "outputTotalsInOtherLanguages.xlsx");

            Console.WriteLine("TotalsInOtherLanguages executed successfully.");
        }

        // ExStart:GlobalizationSettings
        class GlobalizationSettingsImp : GlobalizationSettings
        {
            // This function will return the sub total name
            public override String GetTotalName(ConsolidationFunction functionType)
            {
                return "Chinese Total - 可能的用法";
            }

            // This function will return the grand total name
            public override String GetGrandTotalName(ConsolidationFunction functionType)
            {
                return "Chinese Grand Total - 可能的用法";
            }
        }
        // ExEnd:GlobalizationSettings
    }
}
