﻿using System;
using Aspose.Cells;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    class UpdateRichTextCells
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            string inputPath = dataDir + "Sample.xlsx";
            string outputPath = dataDir + "Output.out.xlsx";

            Workbook workbook = new Workbook(inputPath);

            Worksheet worksheet = workbook.Worksheets[0];

            Cell cell = worksheet.Cells["A1"];

            Console.WriteLine("Before updating the font settings....");

            FontSetting[] fnts = cell.GetCharacters();

            for (int i = 0; i < fnts.Length; i++)
            {
                Console.WriteLine(fnts[i].Font.Name);
            }

            // Modify the first FontSetting Font Name
            fnts[0].Font.Name = "Arial";

            // And update it using SetCharacters() method
            cell.SetCharacters(fnts);

            Console.WriteLine();

            Console.WriteLine("After updating the font settings....");

            fnts = cell.GetCharacters();

            for (int i = 0; i < fnts.Length; i++)
            {
                Console.WriteLine(fnts[i].Font.Name);
            }

            // Save workbook
            workbook.Save(outputPath);
            // ExEnd:1
        }
    }
}
