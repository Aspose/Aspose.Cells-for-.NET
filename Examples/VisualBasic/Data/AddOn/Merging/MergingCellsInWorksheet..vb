Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Data.AddOn.Merging
    Public Class MergingCellsInWorksheet
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Create a Workbook.
            Dim wbk As New Workbook()

            ' Create a Worksheet and get the first sheet.
            Dim worksheet As Worksheet = wbk.Worksheets(0)

            ' Create a Cells object ot fetch all the cells.
            Dim cells As Global.Aspose.Cells.Cells = worksheet.Cells

            ' Merge some Cells (C6:E7) into a single C6 Cell.
            cells.Merge(5, 2, 2, 3)

            ' Input data into C6 Cell.
            worksheet.Cells(5, 2).PutValue("This is my value")

            ' Create a Style object to fetch the Style of C6 Cell.
            Dim style As Style = worksheet.Cells(5, 2).GetStyle()

            ' Create a Font object
            Dim font As Font = style.Font

            ' Set the name.
            font.Name = "Times New Roman"

            ' Set the font size.
            font.Size = 18

            ' Set the font color
            font.Color = System.Drawing.Color.Blue

            ' Bold the text
            font.IsBold = True

            ' Make it italic
            font.IsItalic = True

            ' Set the backgrond color of C6 Cell to Red
            style.ForegroundColor = System.Drawing.Color.Red
            style.Pattern = BackgroundType.Solid

            ' Apply the Style to C6 Cell.
            cells(5, 2).SetStyle(style)

            ' Save the Workbook.
            wbk.Save(dataDir & "output.xls")
            ' ExEnd:1

        End Sub
    End Class
End Namespace