﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells.Pivot;

namespace Aspose.Cells.Examples.CSharp.Articles.PivotTablesAndPivotCharts
{
    public class ChangingLayoutOfPivotTable
    {
        public static void Run()
        {
            //Source directory
            string sourceDir = RunExamples.Get_SourceDirectory();

            //Output directory
            string outputDir = RunExamples.Get_OutputDirectory();

            // Create workbook object from source excel file
            Workbook workbook = new Workbook(sourceDir + "sampleChangingLayoutOfPivotTable.xlsx");

            // Access first worksheet
            Worksheet worksheet = workbook.Worksheets[0];

            // Access first pivot table
            PivotTable pivotTable = worksheet.PivotTables[0];

            // 1 - Show the pivot table in compact form
            pivotTable.ShowInCompactForm();

            // Refresh the pivot table
            pivotTable.RefreshData();
            pivotTable.CalculateData();

            // Save the output
            workbook.Save(outputDir + "outputChangingLayoutOfPivotTable_CompactForm.xlsx");

            // 2 - Show the pivot table in outline form
            pivotTable.ShowInOutlineForm();

            // Refresh the pivot table
            pivotTable.RefreshData();
            pivotTable.CalculateData();

            // Save the output
            workbook.Save(outputDir + "outputChangingLayoutOfPivotTable_OutlineForm.xlsx");

            // 3 - Show the pivot table in tabular form
            pivotTable.ShowInTabularForm();

            // Refresh the pivot table
            pivotTable.RefreshData();
            pivotTable.CalculateData();

            // Save the output
            workbook.Save(outputDir + "outputChangingLayoutOfPivotTable_TabularForm.xlsx");

            Console.WriteLine("ChangingLayoutOfPivotTable executed successfully.");
        }
    }
}
