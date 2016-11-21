Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports Aspose.Cells.Drawing
Imports System.Drawing

Namespace DrawingObjects.Controls
    Public Class AddingGroupBoxControl
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate a new Workbook.
            Dim excelbook As New Workbook()

            ' Add a group box to the first worksheet.
            Dim box As Global.Aspose.Cells.Drawing.GroupBox = excelbook.Worksheets(0).Shapes.AddGroupBox(1, 0, 1, 0, 300, 250)

            ' Set the caption of the group box.
            box.Text = "Age Groups"
            box.Placement = PlacementType.FreeFloating

            ' Make it 2-D box.
            box.Shadow = False

            ' Add a radio button.
            Dim radio1 As Global.Aspose.Cells.Drawing.RadioButton = excelbook.Worksheets(0).Shapes.AddRadioButton(3, 0, 2, 0, 30, 110)

            ' Set its text string.
            radio1.Text = "20-29"

            ' Set A1 cell as a linked cell for the radio button.
            radio1.LinkedCell = "A1"

            ' Make the radio button 3-D.
            radio1.Shadow = True

            ' Set the weight of the radio button.
            radio1.Line.Weight = 4

            ' Set the dash style of the radio button.
            radio1.Line.DashStyle = MsoLineDashStyle.Solid

            ' Add another radio button.
            Dim radio2 As Global.Aspose.Cells.Drawing.RadioButton = excelbook.Worksheets(0).Shapes.AddRadioButton(6, 0, 2, 0, 30, 110)

            ' Set its text string.
            radio2.Text = "30-39"

            ' Set A1 cell as a linked cell for the radio button.
            radio2.LinkedCell = "A1"

            ' Make the radio button 3-D.
            radio2.Shadow = True

            ' Set the weight of the radio button.
            radio2.Line.Weight = 4

            ' Set the dash style of the radio button.
            radio2.Line.DashStyle = MsoLineDashStyle.Solid

            ' Add another radio button.
            Dim radio3 As Global.Aspose.Cells.Drawing.RadioButton = excelbook.Worksheets(0).Shapes.AddRadioButton(9, 0, 2, 0, 30, 110)

            ' Set its text string.
            radio3.Text = "40-49"

            ' Set A1 cell as a linked cell for the radio button.
            radio3.LinkedCell = "A1"

            ' Make the radio button 3-D.
            radio3.Shadow = True

            ' Set the weight of the radio button.
            radio3.Line.Weight = 4

            ' Set the dash style of the radio button.
            radio3.Line.DashStyle = MsoLineDashStyle.Solid

            ' Get the shapes.
            Dim shapeobjects() As Global.Aspose.Cells.Drawing.Shape = {box, radio1, radio2, radio3}

            ' Group the shapes.
            Dim group As Global.Aspose.Cells.Drawing.GroupShape = excelbook.Worksheets(0).Shapes.Group(shapeobjects)

            ' Save the excel file.
            excelbook.Save(dataDir & "output.xls")
            ' ExEnd:1

        End Sub
    End Class
End Namespace