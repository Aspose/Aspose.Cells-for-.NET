﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Cells.Examples.CSharp.Articles.RenderingAndPrinting
{
    public class RenderWorksheetToGraphicContext
    {
        public static void Run()
        {
            //Source directory
            string sourceDir = RunExamples.Get_SourceDirectory();

            //Output directory
            string outputDir = RunExamples.Get_OutputDirectory();

            // Create workbook object from source file
            Workbook workbook = new Workbook(sourceDir + "sampleRenderWorksheetToGraphicContext.xlsx");

            // Access first worksheet
            Worksheet worksheet = workbook.Worksheets[0];

            // Create empty Bitmap
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(1100, 600);

            // Create Graphics Context
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
            g.Clear(System.Drawing.Color.Blue);

            // Set one page per sheet to true in image or print options
            Aspose.Cells.Rendering.ImageOrPrintOptions opts = new Aspose.Cells.Rendering.ImageOrPrintOptions();
            opts.OnePagePerSheet = true;

            // Render worksheet to graphics context
            Aspose.Cells.Rendering.SheetRender sr = new Aspose.Cells.Rendering.SheetRender(worksheet, opts);
            sr.ToImage(0, g, 0, 0);

            // Save the graphics context image in Png format
            bmp.Save(outputDir + "outputRenderWorksheetToGraphicContext.png", System.Drawing.Imaging.ImageFormat.Png);

            Console.WriteLine("RenderWorksheetToGraphicContext executed successfully.");
        }
    }
}
