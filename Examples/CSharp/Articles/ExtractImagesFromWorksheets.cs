using System.IO;
using System;
using Aspose.Cells;
using Aspose.Cells.Rendering;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class ExtractImagesFromWorksheets
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Open a template Excel file
            Workbook workbook = new Workbook(dataDir+ "book1.xls");
            // Get the first worksheet
            Worksheet worksheet = workbook.Worksheets[0];
            // Get the first Picture in the first worksheet
            Aspose.Cells.Drawing.Picture pic = worksheet.Pictures[0];
            // Set the output image file path
            string fileName = dataDir+ "aspose-logo.out.Jpg";
            string picformat = pic.ImageFormat.ToString();
            // Note: you may evaluate the image format before specifying the image path

            // Define ImageOrPrintOptions
            ImageOrPrintOptions printoption = new ImageOrPrintOptions();
            // Specify the image format
            printoption.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            // Save the image
            pic.ToImage(fileName, printoption);
            // ExEnd:1

            Console.WriteLine("\nProcess completed successfully.\nFile saved at " + fileName);
        }
    }
}
