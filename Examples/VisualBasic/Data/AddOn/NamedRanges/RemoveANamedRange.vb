Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Drawing

Namespace Data.AddOn.NamedRanges
    Public Class RemoveANamedRange
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

            ' Get all the worksheets in the book.
            Dim worksheets As WorksheetCollection = workbook.Worksheets

            ' Get the first worksheet in the worksheets collection.
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            ' Create a range of cells.
            Dim range1 As Range = worksheet.Cells.CreateRange("E12", "I12")

            ' Name the range.
            range1.Name = "MyRange"

            ' Set the outline border to the range.
            range1.SetOutlineBorder(BorderType.TopBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128))
            range1.SetOutlineBorder(BorderType.BottomBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128))
            range1.SetOutlineBorder(BorderType.LeftBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128))
            range1.SetOutlineBorder(BorderType.RightBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128))

            ' Input some data with some formattings into
            ' A few cells in the range.
            range1(0, 0).PutValue("Test")
            range1(0, 4).PutValue("123")


            ' Create another range of cells.
            Dim range2 As Range = worksheet.Cells.CreateRange("B3", "F3")

            ' Name the range.
            range2.Name = "testrange"

            ' Copy the first range into second range.
            range2.Copy(range1)

            ' Remove the previous named range (range1) with its contents.
            worksheet.Cells.ClearRange(11, 4, 11, 8)
            worksheets.Names.RemoveAt(0)

            ' Save the excel file.
            workbook.Save(dataDir & "output.xls")
            ' ExEnd:1
        End Sub
    End Class
End Namespace