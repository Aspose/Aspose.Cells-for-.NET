Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Drawing

Namespace Formatting
    Public Class ColorsAndPalette
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiating an Workbook object
            Dim workbook As New Workbook()

            ' Adding Orchid color to the palette at 55th index
            workbook.ChangePalette(Color.Orchid, 55)

            ' Adding a new worksheet to the Excel object
            Dim i As Integer = workbook.Worksheets.Add()

            ' Obtaining the reference of the newly added worksheet by passing its sheet index
            Dim worksheet As Worksheet = workbook.Worksheets(i)

            ' Accessing the "A1" cell from the worksheet
            Dim cell As Cell = worksheet.Cells("A1")

            ' Adding some value to the "A1" cell
            cell.PutValue("Hello Aspose!")

            ' Defining new Style object
            Dim styleObject As Style = workbook.CreateStyle()
            ' Setting the Orchid (custom) color to the font
            styleObject.Font.Color = Color.Orchid

            ' Applying the style to the cell
            cell.SetStyle(styleObject)

            ' Saving the Excel file
            workbook.Save(dataDir & "output.xls", SaveFormat.Auto)
            ' ExEnd:1

        End Sub
    End Class
End Namespace