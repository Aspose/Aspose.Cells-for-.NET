﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells.Charts;

namespace Aspose.Cells.Examples.CSharp.Articles.ManageChartsAndShapes
{
    public class ResizeChartDataLabelToFit
    {
        public static void Run()
        {
            //Source directory
            string sourceDir = RunExamples.Get_SourceDirectory();

            //Output directory
            string outputDir = RunExamples.Get_OutputDirectory();

            // Create an instance of Workbook containing the Chart
            var book = new Workbook(sourceDir + "sampleResizeChartDataLabelToFit.xlsx");

            // Access the Worksheet that contains the Chart
            var sheet = book.Worksheets[0];

            foreach (Chart chart in sheet.Charts)
            {
                for (int index = 0; index < chart.NSeries.Count; index++)
                {
                    // Access the DataLabels of indexed NSeries
                    var labels = chart.NSeries[index].DataLabels;

                    // Set ResizeShapeToFitText property to false
                    labels.IsResizeShapeToFitText = false;
                }

                // Calculate Chart
                chart.Calculate();
            }

             // Save the result
             book.Save(outputDir + "outputResizeChartDataLabelToFit.xlsx");

            Console.WriteLine("ResizeChartDataLabelToFit executed successfully.");
        }
    }
}
