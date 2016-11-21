Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Collections

Namespace Data.Handling.Importing
    Public Class ImportingFromArrayList
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiating a Workbook object
            Dim workbook As New Workbook()

            ' Obtaining the reference of the worksheet
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            ' Instantiating an ArrayList object
            Dim list As New ArrayList()

            ' Add few names to the list as string values
            list.Add("laurence chen")
            list.Add("roman korchagin")
            list.Add("kyle huang")
            list.Add("tommy wang")

            ' Importing the contents of ArrayList to 1st row and first column vertically
            worksheet.Cells.ImportArrayList(list, 0, 0, True)

            ' Saving the Excel file
            workbook.Save(dataDir & "output.xls")
            ' ExEnd:1

        End Sub
    End Class
End Namespace