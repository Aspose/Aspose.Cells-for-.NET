using System.IO;

using Aspose.Cells;
using System.Drawing;

namespace Aspose.Cells.Examples.CSharp.Data.AddOn.NamedRanges
{
    public class IntersectionofRanges
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Instantiate a workbook object.
            // Open an existing excel file.
            Workbook workbook = new Workbook(dataDir + "book1.xls");

            // Get the named ranges.
            Range[] ranges = workbook.Worksheets.GetNamedRanges();

            // Check whether the first range intersect the second range.
            bool isintersect = ranges[0].IsIntersect(ranges[1]);

            // Create a style object.
            Style style = workbook.CreateStyle();

            // Set the shading color with solid pattern type.
            style.ForegroundColor = Color.Yellow;
            style.Pattern = BackgroundType.Solid;

            // Create a styleflag object.
            StyleFlag flag = new StyleFlag();

            // Apply the cellshading.
            flag.CellShading = true;

            // If first range intersects second range.
            if (isintersect)
            {
                // Create a range by getting the intersection.
                Range intersection = ranges[0].Intersect(ranges[1]);

                // Name the range.
                intersection.Name = "Intersection";

                // Apply the style to the range.
                intersection.ApplyStyle(style, flag);

            }

            // Save the excel file.
            workbook.Save(dataDir + "rngIntersection.out.xls");
            // ExEnd:1
        }
    }
}
