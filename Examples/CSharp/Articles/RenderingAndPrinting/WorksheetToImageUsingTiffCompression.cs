﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells.Rendering;

namespace Aspose.Cells.Examples.CSharp.Articles.RenderingAndPrinting
{
    public class WorksheetToImageUsingTiffCompression
    {
        public static void Run()
        {
            // ExStart:WorksheetToImageUsingTiffCompression
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Instantiate a new Workbook object with template
            Workbook book = new Workbook(dataDir + "SampleBook.xlsx");

            // Get the first worksheet
            Worksheet sheet = book.Worksheets[0];

            // Apply different Image and Print options
            Aspose.Cells.Rendering.ImageOrPrintOptions options = new Aspose.Cells.Rendering.ImageOrPrintOptions();

            // Set Horizontal Resolution
            options.HorizontalResolution = 300;

            // Set Vertical Resolution
            options.VerticalResolution = 300;

            // Set TiffCompression
            options.TiffCompression = Aspose.Cells.Rendering.TiffCompression.CompressionLZW;

            // Set Autofit options
            options.IsCellAutoFit = false;

            // Set Image Format
            options.ImageFormat = System.Drawing.Imaging.ImageFormat.Tiff;

            // Set printing page type
            options.PrintingPage = PrintingPageType.Default;

            // Render the sheet with respect to specified image/print options
            SheetRender sr = new SheetRender(sheet, options);

            // Render/save the image for the sheet
            sr.ToImage(0, dataDir + @"SheetImage_out_.tiff");
            // ExEnd:WorksheetToImageUsingTiffCompression
        }
    }
}
