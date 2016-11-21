﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Cells.Examples.CSharp.Articles.RenderingAndPrinting
{
    public class WorksheetToImageDesiredSize
    {
        public static void Run()
        {
            // ExStart:WorksheetToImageDesiredSize
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create workbook object from source file
            Workbook workbook = new Workbook(dataDir + "SampleBook.xlsx");

            // Access first worksheet
            Worksheet worksheet = workbook.Worksheets[0];

            // Set image or print options we want one page per sheet. The image format is in png and desired dimensions are 400x400
            Aspose.Cells.Rendering.ImageOrPrintOptions opts = new Aspose.Cells.Rendering.ImageOrPrintOptions();
            opts.OnePagePerSheet = true;
            opts.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
            opts.SetDesiredSize(400, 400);

            // Render sheet into image
            Aspose.Cells.Rendering.SheetRender sr = new Aspose.Cells.Rendering.SheetRender(worksheet, opts);
            sr.ToImage(0, dataDir + "ImageWithDesiredSize_out_.png");
            // ExEnd:WorksheetToImageDesiredSize
        }
    }
}
