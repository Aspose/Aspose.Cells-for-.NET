Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports Aspose.Cells.Drawing
Imports System.Drawing

Namespace DrawingObjects.Controls
    Public Class AddinganArrowHead
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If Not IsExists Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate a new Workbook.
            Dim workbook As New Workbook()

            ' Get the first worksheet in the book.
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            ' Add a line to the worksheet
            Dim line2 As Aspose.Cells.Drawing.LineShape = worksheet.Shapes.AddLine(7, 0, 1, 0, 85, 250)

            ' Set the line color
            line2.Line.FillType = FillType.Solid
            line2.Line.SolidFill.Color = Color.Blue

            ' Set the weight of the line.
            line2.Line.Weight = 3

            ' Set the placement.
            line2.Placement = PlacementType.FreeFloating

            ' Set the line arrows.
            line2.Line.EndArrowheadWidth = MsoArrowheadWidth.Medium
            line2.Line.EndArrowheadStyle = MsoArrowheadStyle.Arrow
            line2.Line.EndArrowheadLength = MsoArrowheadLength.Medium
            line2.Line.BeginArrowheadStyle = MsoArrowheadStyle.ArrowDiamond
            line2.Line.BeginArrowheadLength = MsoArrowheadLength.Medium

            ' Make the gridlines invisible in the first worksheet.
            workbook.Worksheets(0).IsGridlinesVisible = False

            ' Save the excel file.
            workbook.Save(dataDir & Convert.ToString("book1.out.xlsx"))
            ' ExEnd:1
        End Sub
    End Class
End Namespace