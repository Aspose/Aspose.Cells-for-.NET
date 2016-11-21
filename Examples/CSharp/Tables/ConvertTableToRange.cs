using System.IO;

using Aspose.Cells;

namespace Aspose.Cells.Examples.CSharp.Tables
{
    public class ConvertTableToRange
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Open an existing file that contains a table/list object in it
            Workbook wb = new Workbook(dataDir + "book1.xlsx");

            // Convert the first table/list object (from the first worksheet) to normal range
            wb.Worksheets[0].ListObjects[0].ConvertToRange();

            // Save the file
            wb.Save(dataDir + "output.xlsx");
            // ExEnd:1

        }
    }
}
