Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Collections

Namespace Articles
    Public Class AddPDFBookmarks
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate a new workbook
            Dim workbook As New Workbook()
            ' Get the cells in the first(default) worksheet
            Dim cells As Global.Aspose.Cells.Cells = workbook.Worksheets(0).Cells
            ' Get the A1 cell
            Dim p As Global.Aspose.Cells.Cell = cells("A1")
            ' Enter a value
            p.PutValue("Preface")
            ' Get the A10 cell
            Dim A As Global.Aspose.Cells.Cell = cells("A10")
            ' Enter a value.
            A.PutValue("page1")
            ' Get the H15 cell
            Dim D As Global.Aspose.Cells.Cell = cells("H15")
            ' Enter a value
            D.PutValue("page1(H15)")
            ' Add a new worksheet to the workbook
            workbook.Worksheets.Add()
            ' Get the cells in the second sheet
            cells = workbook.Worksheets(1).Cells
            ' Get the B10 cell in the second sheet
            Dim B As Global.Aspose.Cells.Cell = cells("B10")
            ' Enter a value
            B.PutValue("page2")
            ' Add a new worksheet to the workbook
            workbook.Worksheets.Add()
            ' Get the cells in the third sheet
            cells = workbook.Worksheets(2).Cells
            ' Get the C10 cell in the third sheet
            Dim C As Global.Aspose.Cells.Cell = cells("C10")
            ' Enter a value
            C.PutValue("page3")

            ' Create a main PDF Bookmark entry object
            Dim pbeRoot As New Global.Aspose.Cells.Rendering.PdfBookmarkEntry()
            ' Specify its text
            pbeRoot.Text = "Sections"
            ' Set the destination cell/location
            pbeRoot.Destination = p

            ' Set its sub entry array list
            pbeRoot.SubEntry = New ArrayList()

            ' Create a sub PDF Bookmark entry object
            Dim subPbe1 As New Global.Aspose.Cells.Rendering.PdfBookmarkEntry()
            ' Specify its text
            subPbe1.Text = "Section 1"
            ' Set its destination cell
            subPbe1.Destination = A
            ' Define/Create a sub Bookmark entry object of "Section A"
            Dim ssubPbe As New Global.Aspose.Cells.Rendering.PdfBookmarkEntry()
            ' Specify its text
            ssubPbe.Text = "Section 1.1"
            ' Set its destination
            ssubPbe.Destination = D
            ' Create/Set its sub entry array list object
            subPbe1.SubEntry = New ArrayList()
            ' Add the object to "Section 1"
            subPbe1.SubEntry.Add(ssubPbe)
            ' Add the object to the main PDF root object
            pbeRoot.SubEntry.Add(subPbe1)

            ' Create a sub PDF Bookmark entry object
            Dim subPbe2 As New Global.Aspose.Cells.Rendering.PdfBookmarkEntry()
            ' Specify its text
            subPbe2.Text = "Section 2"
            ' Set its destination
            subPbe2.Destination = B
            ' Add the object to the main PDF root object
            pbeRoot.SubEntry.Add(subPbe2)

            ' Create a sub PDF Bookmark entry object
            Dim subPbe3 As New Global.Aspose.Cells.Rendering.PdfBookmarkEntry()
            ' Specify its text
            subPbe3.Text = "Section 3"
            ' Set its destination
            subPbe3.Destination = C
            ' Add the object to the main PDF root object
            pbeRoot.SubEntry.Add(subPbe3)

            ' Create an instance of PdfSaveOptions
            Dim pdfSaveOptions As New Global.Aspose.Cells.PdfSaveOptions()

            ' Set the PDF Bookmark root object
            pdfSaveOptions.Bookmark = pbeRoot

            ' Save the pdf file
            workbook.Save(dataDir & "output.pdf", pdfSaveOptions)
            ' ExEnd:1


        End Sub
    End Class
End Namespace