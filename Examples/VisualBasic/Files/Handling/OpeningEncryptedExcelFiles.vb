Imports System.IO

Imports Aspose.Cells
Imports System

Namespace Files.Handling
    Public Class OpeningEncryptedExcelFiles
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Instantiate LoadOptions
            Dim loadOptions6 As New LoadOptions()

            ' Specify the password
            loadOptions6.Password = "1234"

            ' Create a Workbook object and opening the file from its path
            Dim wbEncrypted As New Workbook(dataDir & "encryptedBook.xls", loadOptions6)
            Console.WriteLine("Encrypted excel file opened successfully!")
            ' ExEnd:1
        End Sub
    End Class
End Namespace
