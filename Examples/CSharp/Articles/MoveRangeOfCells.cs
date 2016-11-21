using System.IO;

using Aspose.Cells;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class MoveRangeOfCells
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            // Instantiate the workbook object
            // Open the Excel file
            Workbook workbook = new Workbook(dataDir+ "book1.xls");

            Cells cells = workbook.Worksheets[0].Cells;

            // Create Cell's area
            CellArea ca = new CellArea();
            ca.StartColumn = 0;
            ca.EndColumn = 1;
            ca.StartRow = 0;
            ca.EndRow = 4;

            // Move Range
            cells.MoveRange(ca, 0, 2);

            // Save the resultant file
            workbook.Save(dataDir+ "book2.out.xls");
            // ExEnd:1
        }
    }
}