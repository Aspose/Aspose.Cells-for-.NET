Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Articles
    Public Class CreateManipulateRemoveScenarios
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            ' Instantiate the Workbook
            ' Load an Excel file
            Dim workbook As Workbook = New Workbook(dataDir & "aspose-sample.xlsx")
            ' Access first worksheet
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            If worksheet.Scenarios.Count > 0 Then
                ' Remove the existing first scenario from the sheet
                worksheet.Scenarios.RemoveAt(0)

                ' Create a scenario
                Dim i As Integer = worksheet.Scenarios.Add("MyScenario")
                ' Get the scenario
                Dim scenario As Scenario = worksheet.Scenarios(i)
                ' Add comment to it
                scenario.Comment = "Test sceanrio is created."
                ' Get the input cells for the scenario
                Dim sic As ScenarioInputCellCollection = scenario.InputCells
                ' Add the scenario on B4 (as changing cell) with default value
                sic.Add(3, 1, "1100000")
                ' Save the Excel file.
                workbook.Save(dataDir & "output.xlsx")
            End If
            ' ExEnd:1
        End Sub
    End Class
End Namespace