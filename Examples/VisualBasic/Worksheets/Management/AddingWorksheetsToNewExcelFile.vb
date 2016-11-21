Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Worksheets.Management
    Public Class AddingWorksheetsToNewExcelFile
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Instantiating a Workbook object
            Dim workbook As New Workbook()

            ' Adding a new worksheet to the Workbook object
            Dim i As Integer = workbook.Worksheets.Add()

            ' Obtaining the reference of the newly added worksheet by passing its sheet index
            Dim worksheet As Worksheet = workbook.Worksheets(i)

            ' Setting the name of the newly added worksheet
            worksheet.Name = "My Worksheet"

            ' Saving the Excel file
            workbook.Save(dataDir & "output.xls")
            ' ExEnd:1
        End Sub
    End Class
End Namespace