Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports Aspose.Cells.Charts

Namespace Charts.SettingChartsAppearance
    Public Class ApplyingThemes
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Instantiate the workbook to open the file that contains a chart
            Dim workbook As New Workbook(dataDir & "book1.xlsx")

            ' Get the first worksheet
            Dim worksheet As Worksheet = workbook.Worksheets(1)

            ' Get the first chart in the sheet
            Dim chart As Chart = worksheet.Charts(0)

            ' Specify the FilFormat' S type to Solid Fill of the first series
            chart.NSeries(0).Area.FillFormat.FillType = Global.Aspose.Cells.Drawing.FillType.Solid

            ' Get the CellsColor of SolidFill
            Dim cc As CellsColor = chart.NSeries(0).Area.FillFormat.SolidFill.CellsColor

            ' Create a theme in Accent style
            cc.ThemeColor = New ThemeColor(ThemeColorType.Accent6, 0.6)

            ' Apply the them to the series
            chart.NSeries(0).Area.FillFormat.SolidFill.CellsColor = cc

            ' Save the Excel file
            workbook.Save(dataDir & "output.xlsx")
            ' ExEnd:1

        End Sub
    End Class
End Namespace