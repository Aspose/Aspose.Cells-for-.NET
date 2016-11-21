Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Worksheets.Security.Protecting
    Public Class ProtectingSpecificColumnInWorksheet
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Create a new workbook.
            Dim wb As New Workbook()

            ' Create a worksheet object and obtain the first sheet.
            Dim sheet As Worksheet = wb.Worksheets(0)

            ' Define the style object.
            Dim style As Style

            ' Define the styleflag object.
            Dim flag As StyleFlag

            ' Loop through all the columns in the worksheet and unlock them.
            For i As Integer = 0 To 255
                style = sheet.Cells.Columns(CByte(i)).Style
                style.IsLocked = False
                flag = New StyleFlag()
                flag.Locked = True
                sheet.Cells.Columns(CByte(i)).ApplyStyle(style, flag)

            Next i

            ' Get the first column style.
            style = sheet.Cells.Columns(0).Style

            ' Lock it.
            style.IsLocked = True

            ' Instantiate the flag.
            flag = New StyleFlag()

            ' Set the lock setting.
            flag.Locked = True

            ' Apply the style to the first column.
            sheet.Cells.Columns(0).ApplyStyle(style, flag)

            ' Protect the sheet.
            sheet.Protect(ProtectionType.All)

            ' Save the excel file.
            wb.Save(dataDir & "output.xls", SaveFormat.Excel97To2003)
            ' ExEnd:1


        End Sub
    End Class
End Namespace