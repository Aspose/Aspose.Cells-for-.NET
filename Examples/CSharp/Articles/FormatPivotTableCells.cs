using System.IO;
using System;
using Aspose.Cells;
using Aspose.Cells.Pivot;
using System.Drawing;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class FormatPivotTableCells
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            string filePath = dataDir + "pivotTable_test.xlsx";

            // Create workbook object from source file containing pivot table
            Workbook workbook = new Workbook(filePath);

            // Access the worksheet by its name
            Worksheet worksheet = workbook.Worksheets["PivotTable"];

            // Access the pivot table
            // PivotTable pivotTable = worksheet.PivotTables[0];

            // Create a style object with background color light blue
            Style style = workbook.CreateStyle();
            style.Pattern = BackgroundType.Solid;
            style.BackgroundColor = Color.LightBlue;

            // Format entire pivot table with light blue color
           // worksheet.FormatAll(style);

            // Create another style object with yellow color
            style = workbook.CreateStyle();
            style.Pattern = BackgroundType.Solid;
            style.BackgroundColor = Color.Yellow;

            // Format the cells of the first row of the pivot table with yellow color
            for (int col = 0; col < 5; col++)
            {
               // worksheet.Format(1, col, style);
            }
            dataDir = dataDir + "output.out.xlsx";
            // Save the workbook object
            workbook.Save(dataDir);
            // ExEnd:1
            Console.WriteLine("\nProcess completed successfully.\nFile saved at " + dataDir);
        }
    }
}
