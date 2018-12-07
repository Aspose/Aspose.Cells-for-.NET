﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Cells.Examples.CSharp.Data
{
    public class SettingSimpleFormulaWithRange
    {
        //Output directory
        static string outputDir = RunExamples.Get_OutputDirectory();

        public static void Run()
        {
            // Create an instance of Workbook
            Workbook book = new Workbook();

            // Get the WorksheetCollection
            WorksheetCollection worksheets = book.Worksheets;

            // Add a new Named Range with name "NewNamedRange"
            int index = worksheets.Names.Add("NewNamedRange");

            // Access the newly created Named Range
            Name name = worksheets.Names[index];

            // Set RefersTo property of the Named Range to a formula. Formula references another cell in the same worksheet
            name.RefersTo = "=Sheet1!$A$3";

            // Set the formula in the cell A1 to the newly created Named Range
            worksheets[0].Cells["A1"].Formula = "NewNamedRange";

            // Insert the value in cell A3 which is being referenced in the Named Range
            worksheets[0].Cells["A3"].PutValue("This is the value of A3");

            // Calculate formulas
            book.CalculateFormula();

            // Save the result in XLSX format
            book.Save(outputDir + "outputSettingSimpleFormulaWithRange.xlsx");

            Console.WriteLine("SettingSimpleFormulaWithRange executed successfully.");
        }
    }
}
