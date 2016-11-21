Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Worksheets.Security.Protecting
    Public Class ProtectingSpecificCellsinaWorksheet
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

            ' Define the styleflag object
            Dim styleflag As StyleFlag

            ' Loop through all the columns in the worksheet and unlock them.
            For i As Integer = 0 To 255

                style = sheet.Cells.Columns(CByte(i)).Style
                style.IsLocked = False
                styleflag = New StyleFlag()
                styleflag.Locked = True
                sheet.Cells.Columns(CByte(i)).ApplyStyle(style, styleflag)

            Next i

            ' Lock the three cells...i.e. A1, B1, C1.
            style = sheet.Cells("A1").GetStyle()
            style.IsLocked = True
            sheet.Cells("A1").SetStyle(style)
            style = sheet.Cells("B1").GetStyle()
            style.IsLocked = True
            sheet.Cells("B1").SetStyle(style)
            style = sheet.Cells("C1").GetStyle()
            style.IsLocked = True
            sheet.Cells("C1").SetStyle(style)

            ' Finally, Protect the sheet now.
            sheet.Protect(ProtectionType.All)

            ' Save the excel file.
            wb.Save(dataDir & "output.xls", SaveFormat.Excel97To2003)
            ' ExEnd:1

        End Sub
    End Class
End Namespace