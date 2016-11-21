Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Formatting.ApproachesToFormatData
    Public Class UsingExcelPredefinedStyles
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate a new Workbook.
            Dim workbook As New Workbook()

            ' Create a style object based on a predefined Excel 2007 style.
            Dim style As Style = workbook.CreateStyle()

            ' Input a value to A1 cell.
            workbook.Worksheets(0).Cells("A1").PutValue("Test")

            ' Apply the style to the cell.
            workbook.Worksheets(0).Cells("A1").SetStyle(style)

            ' Save the Excel 2007 file.
            workbook.Save(dataDir & "output.xlsx")
            ' ExEnd:1
        End Sub
    End Class
End Namespace