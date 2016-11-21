Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System

Namespace Files.Handling
    Public Class SaveWorkbookToTextCSVFormat
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Load your source workbook
            Dim workbook As New Workbook(dataDir & "book1.xls")

            '0-byte array
            Dim workbookData(-1) As Byte

            ' Text save options. You can use any type of separator
            Dim opts As New TxtSaveOptions()
            opts.Separator = ControlChars.Tab

            ' Copy each worksheet data in text format inside workbook data array
            For idx As Integer = 0 To workbook.Worksheets.Count - 1
                ' Save the active worksheet into text format
                Dim ms As New MemoryStream()
                workbook.Worksheets.ActiveSheetIndex = idx
                workbook.Save(ms, opts)

                ' Save the worksheet data into sheet data array
                ms.Position = 0
                Dim sheetData() As Byte = ms.ToArray()

                ' Combine this worksheet data into workbook data array
                Dim combinedArray(workbookData.Length + sheetData.Length - 1) As Byte
                Array.Copy(workbookData, 0, combinedArray, 0, workbookData.Length)
                Array.Copy(sheetData, 0, combinedArray, workbookData.Length, sheetData.Length)

                workbookData = combinedArray
            Next idx

            ' Save entire workbook data into file
            File.WriteAllBytes(dataDir & "output.txt", workbookData)
            ' ExEnd:1

        End Sub
    End Class
End Namespace