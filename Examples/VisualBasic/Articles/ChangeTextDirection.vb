Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Articles
    Public Class ChangeTextDirection
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate a new Workbook
            Dim wb = New Workbook()
            ' Get the first worksheet
            Dim sheet = wb.Worksheets(0)

            ' Add a comment to A1 cell
            Dim comment = sheet.Comments(sheet.Comments.Add("A1"))
            ' Set its vertical alignment setting            
            comment.CommentShape.TextVerticalAlignment = TextAlignmentType.Center
            ' Set its horizontal alignment setting
            comment.CommentShape.TextHorizontalAlignment = TextAlignmentType.Right
            ' Set the Text Direction - Right-to-Left
            comment.CommentShape.TextDirection = TextDirectionType.RightToLeft
            ' Set the Comment note
            comment.Note = "This is my Comment Text. This is test"

            ' Save the Excel file
            wb.Save(dataDir & "output.xlsx")
            ' ExEnd:1



        End Sub
    End Class
End Namespace