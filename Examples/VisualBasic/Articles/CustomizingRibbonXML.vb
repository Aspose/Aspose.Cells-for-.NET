Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Articles
    Public Class CustomizingRibbonXML
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim wb As New Workbook(dataDir & "aspose-sample.xlsx")
            Dim fi As New FileInfo(dataDir & "CustomUI.xml")
            Dim sr As StreamReader = fi.OpenText()
            wb.RibbonXml = sr.ReadToEnd()
            sr.Close()
            ' ExEnd:1


        End Sub
    End Class
End Namespace