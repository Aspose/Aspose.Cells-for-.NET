using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.CSharp.Data.Handling.Find
{
    public class FindDataOrFormulas
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Instantiate the workbook object
            Workbook workbook = new Workbook(dataDir + "book1.xls");

            // Get Cells collection
            Cells cells = workbook.Worksheets[0].Cells;

            // Instantiate FindOptions Object
            FindOptions findOptions = new FindOptions();

            // Create a Cells Area
            CellArea ca = new CellArea();
            ca.StartRow = 8;
            ca.StartColumn = 2;
            ca.EndRow = 17;
            ca.EndColumn = 13;

            // Set cells area for find options
            findOptions.SetRange(ca);

            // Set searching properties
            findOptions.SearchNext = true;
            findOptions.SeachOrderByRows = true;

            // Set the lookintype, you may specify, values, formulas, comments etc.
            findOptions.LookInType = LookInType.Values;

            // Set the lookattype, you may specify Match entire content, endswith, starwith etc.
            findOptions.LookAtType = LookAtType.EntireContent;

            // Find the cell with value
            Cell cell = cells.Find(205, null, findOptions);

            if (cell != null)
            {
                Console.WriteLine("Name of the cell containing the value: " + cell.Name);
            }
            else
            {
                Console.WriteLine("Record not found ");
            }
            // ExEnd:1
        }
    }
}
