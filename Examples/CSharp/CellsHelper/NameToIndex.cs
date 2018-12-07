using System;

namespace Aspose.Cells.Examples.CSharp._CellsHelper
{
    public class NameToIndex
    {
        public static void Run()
        {
            string name = "C4";
            int row;
            int column;
            Aspose.Cells.CellsHelper.CellNameToIndex(name, out row, out column);
            Console.WriteLine("Row: {0}, Column: {1}", row, column);

            Console.WriteLine("NameToIndex executed successfully.");
        }
    }
}
