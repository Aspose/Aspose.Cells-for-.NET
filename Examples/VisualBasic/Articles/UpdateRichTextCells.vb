﻿Imports System.IO
Imports Aspose.Cells

Namespace Articles
    Public Class UpdateRichTextCells
        Public Shared Sub Run()
            ' ExStart:1
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim inputPath As String = dataDir & "Sample.xlsx"
            Dim outputPath As String = dataDir & "Output.out.xlsx"

            Dim workbook As Workbook = New Workbook(inputPath)

            Dim worksheet As Worksheet = workbook.Worksheets(0)

            Dim cell As Cell = worksheet.Cells("A1")

            Console.WriteLine("Before updating the font settings....")
            Dim fnts As FontSetting() = cell.GetCharacters

            For i As Integer = 0 To fnts.Length - 1
                Console.WriteLine(fnts(i).Font.Name)
            Next

            ' Modify the first FontSetting Font Name
            fnts(0).Font.Name = "Arial"

            ' And update it using SetCharacters() method
            cell.SetCharacters(fnts)

            Console.WriteLine()

            Console.WriteLine("After updating the font settings....")

            fnts = cell.GetCharacters()
            For i As Integer = 0 To fnts.Length - 1
                Console.WriteLine(fnts(i).Font.Name)
            Next

            ' Save workbook
            workbook.Save(outputPath)
            ' ExEnd:1
        End Sub
    End Class
End Namespace
