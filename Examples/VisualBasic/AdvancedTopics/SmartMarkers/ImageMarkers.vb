Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Data

Namespace AdvancedTopics.SmartMarkers
    Public Class ImageMarkers
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Get the image data.
            Dim imageData() As Byte = File.ReadAllBytes(dataDir & "aspose-logo.jpg")
            ' Create a datatable.
            Dim t As New DataTable("Table1")
            ' Add a column to save pictures.
            Dim dc As DataColumn = t.Columns.Add("Picture")
            ' Set its data type.
            dc.DataType = GetType(Object)

            ' Add a new new record to it.
            Dim row As DataRow = t.NewRow()
            row(0) = imageData
            t.Rows.Add(row)

            ' Add another record (having picture) to it.
            imageData = File.ReadAllBytes(dataDir & "image2.jpg")
            row = t.NewRow()
            row(0) = imageData
            t.Rows.Add(row)

            ' Create WorkbookDesigner object.
            Dim designer As New WorkbookDesigner()
            ' Open the template Excel file.
            designer.Workbook = New Workbook(dataDir & "TestSmartMarkers.xlsx")
            ' Set the datasource.
            designer.SetDataSource(t)
            ' Process the markers.
            designer.Process()
            ' Save the Excel file.
            designer.Workbook.Save(dataDir & "SmartBook.output.xls")
            ' ExEnd:1


        End Sub
    End Class
End Namespace