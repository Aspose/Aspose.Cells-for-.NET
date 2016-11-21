Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Drawing
Imports System.Collections

Namespace Data.AddOn.NamedRanges
    Public Class UnionOfRanges
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Instantiate a workbook object.
            ' Open an existing excel file.
            Dim workbook As New Workbook(dataDir & "book1.xls")

            ' Get the named ranges.
            Dim ranges() As Range = workbook.Worksheets.GetNamedRanges()

            ' Create a style object.
            Dim style As Style = workbook.CreateStyle()

            ' Set the shading color with solid pattern type.
            style.ForegroundColor = Color.Yellow
            style.Pattern = BackgroundType.Solid

            ' Create a styleflag object.
            Dim flag As New StyleFlag()

            ' Apply the cellshading.
            flag.CellShading = True

            ' Creates an arraylist.
            Dim al As New ArrayList()

            ' Get the arraylist collection apply the union operation.
            al = ranges(0).Union(ranges(1))

            ' Define a range object.
            Dim rng As Range
            Dim frow, fcol, erow, ecol As Integer

            For i As Integer = 0 To al.Count - 1
                ' Get a range.
                rng = CType(al(i), Range)
                frow = rng.FirstRow
                fcol = rng.FirstColumn
                erow = rng.RowCount
                ecol = rng.ColumnCount

                ' Apply the style to the range.
                rng.ApplyStyle(style, flag)

            Next i

            ' Save the excel file.
            workbook.Save(dataDir & "output.xls")
            ' ExEnd:1
        End Sub
    End Class
End Namespace