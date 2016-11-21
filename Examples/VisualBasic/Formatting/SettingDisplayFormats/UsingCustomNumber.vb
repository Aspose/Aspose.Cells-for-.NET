Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System

Namespace Formatting.SettingDisplayFormats
    Public Class UsingCustomNumber
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiating a Workbook object
            Dim workbook As New Workbook()

            ' Adding a new worksheet to the Excel object
            Dim i As Integer = workbook.Worksheets.Add()

            ' Obtaining the reference of the newly added worksheet by passing its sheet index
            Dim worksheet As Worksheet = workbook.Worksheets(i)

            ' Adding the current system date to "A1" cell
            worksheet.Cells("A1").PutValue(DateTime.Now)

            ' Getting the style of A1 cell
            Dim style As Style = worksheet.Cells("A1").GetStyle()

            ' Setting the custom display format to show date as "d-mmm-yy"
            style.Custom = "d-mmm-yy"

            ' Applying the style to A1 cell
            worksheet.Cells("A1").SetStyle(style)

            ' Adding a numeric value to "A2" cell
            worksheet.Cells("A2").PutValue(20)

            ' Getting the style of A2 cell
            style = worksheet.Cells("A2").GetStyle()

            ' Setting the custom display format to show value as percentage
            style.Custom = "0.0%"

            ' Applying the style to A2 cell
            worksheet.Cells("A2").SetStyle(style)

            ' Adding a numeric value to "A3" cell
            worksheet.Cells("A3").PutValue(2546)

            ' Getting the style of A3 cell
            style = worksheet.Cells("A3").GetStyle()

            ' Setting the custom display format to show value as currency
            style.Custom = "�#,##0;[Red]$-#,##0"

            ' Applying the style to A3 cell
            worksheet.Cells("A3").SetStyle(style)

            ' Saving the Excel file
            workbook.Save(dataDir & "output.xls", SaveFormat.Excel97To2003)
            ' ExEnd:1

        End Sub
    End Class
End Namespace