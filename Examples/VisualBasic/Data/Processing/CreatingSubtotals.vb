Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Data.Processing
    Public Class CreatingSubtotals
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Instantiate a new workbook
            ' Open the template file
            Dim workbook As New Workbook(dataDir & "book1.xls")

            ' Get the Cells collection in the first worksheet
            Dim cells As Global.Aspose.Cells.Cells = workbook.Worksheets(0).Cells

            ' Create a cellarea i.e.., B3:C19
            Dim ca As New CellArea()
            ca.StartRow = 2
            ca.StartColumn = 1
            ca.EndRow = 18
            ca.EndColumn = 2

            ' Apply subtotal, the consolidation function is Sum and it will applied to
            ' Second column (C) in the list
            cells.Subtotal(ca, 0, ConsolidationFunction.Sum, New Integer() {1})

            ' Save the excel file
            workbook.Save(dataDir & "output.xls")
            ' ExEnd:1
        End Sub
    End Class
End Namespace