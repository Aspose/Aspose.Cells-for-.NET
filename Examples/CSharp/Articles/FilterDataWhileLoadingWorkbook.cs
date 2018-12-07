using System.IO;
using System;
using Aspose.Cells;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class FilterDataWhileLoadingWorkbook
    {
        public static void Run()
        {
            //Source directory
            string sourceDir = RunExamples.Get_SourceDirectory();

            //Output directory
            string outputDir = RunExamples.Get_OutputDirectory();

            // Set the load options, we only want to load shapes and do not want to load data
            LoadOptions loadOptions = new LoadOptions(LoadFormat.Xlsx);
            loadOptions.LoadFilter = new LoadFilter(LoadDataFilterOptions.Shape);

            // Create workbook object from sample excel file using load options
            Workbook book = new Workbook(sourceDir + "sampleFilterDataWhileLoadingWorkbook.xlsx", loadOptions);

            // Save the output in pdf format
            book.Save(outputDir + "outputFilterDataWhileLoadingWorkbook.pdf", SaveFormat.Pdf);

            Console.WriteLine("FilterDataWhileLoadingWorkbook executed successfully.");
        }
    }
}
