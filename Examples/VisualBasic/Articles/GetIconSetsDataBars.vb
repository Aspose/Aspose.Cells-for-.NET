Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Articles
    Public Class GetIconSetsDataBars
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            ' Open a template Excel file
            Dim workbook As New Workbook(dataDir & "book1.xlsx")

            ' Get the first worksheet in the workbook
            Dim sheet As Worksheet = workbook.Worksheets(0)

            ' Get the A1 cell
            Dim cell As Cell = sheet.Cells("A1")

            ' Get the conditional formatting result object
            Dim cfr As ConditionalFormattingResult = cell.GetConditionalFormattingResult()

            ' Get the icon set
            Dim icon As ConditionalFormattingIcon = cfr.ConditionalFormattingIcon

            ' Create the image file based on the icon' S image data
            File.WriteAllBytes(dataDir & "output.jpg", icon.ImageData)
            ' ExEnd:1

        End Sub
    End Class
End Namespace