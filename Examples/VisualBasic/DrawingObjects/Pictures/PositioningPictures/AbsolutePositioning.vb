Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace DrawingObjects.Pictures.PositioningPictures
    Public Class AbsolutePositioning
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Instantiating a Workbook object
            Dim workbook As New Workbook()

            ' Adding a new worksheet to the Workbook object
            Dim sheetIndex As Integer = workbook.Worksheets.Add()

            ' Obtaining the reference of the newly added worksheet by passing its sheet index
            Dim worksheet As Worksheet = workbook.Worksheets(sheetIndex)

            ' Adding a picture at the location of a cell whose row and column indices
            ' Are 5 in the worksheet. It is "F6" cell
            Dim pictureIndex As Integer = worksheet.Pictures.Add(5, 5, dataDir & "logo.jpg")

            ' Accessing the newly added picture
            Dim picture As Global.Aspose.Cells.Drawing.Picture = worksheet.Pictures(pictureIndex)

            ' Absolute positioning of the picture in unit of pixels
            picture.Left = 60
            picture.Top = 10

            ' Saving the Excel file
            workbook.Save(dataDir & "output.xls")
            ' ExEnd:1

        End Sub
    End Class
End Namespace