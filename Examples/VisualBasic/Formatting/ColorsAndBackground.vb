Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Drawing

Namespace Formatting
    Public Class ColorsAndBackground
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

            ' Adding a new worksheet to the Workbook object
            Dim i As Integer = workbook.Worksheets.Add()

            ' Obtaining the reference of the newly added worksheet by passing its sheet index
            Dim worksheet As Worksheet = workbook.Worksheets(i)

            ' Define a Style and get the A1 cell style
            Dim style As Style = worksheet.Cells("A1").GetStyle()

            ' Setting the foreground color to yellow
            style.ForegroundColor = Color.Yellow

            ' Setting the background pattern to vertical stripe
            style.Pattern = BackgroundType.VerticalStripe

            ' Apply the style to A1 cell
            worksheet.Cells("A1").SetStyle(style)

            ' Get the A2 cell style
            style = worksheet.Cells("A2").GetStyle()

            ' Setting the foreground color to blue
            style.ForegroundColor = Color.Blue

            ' Setting the background color to yellow
            style.BackgroundColor = Color.Yellow

            ' Setting the background pattern to vertical stripe
            style.Pattern = BackgroundType.VerticalStripe

            ' Apply the style to A2 cell
            worksheet.Cells("A2").SetStyle(style)

            ' Saving the Excel file
            workbook.Save(dataDir & "output.xls", SaveFormat.Excel97To2003)
            ' ExEnd:1

        End Sub
    End Class
End Namespace