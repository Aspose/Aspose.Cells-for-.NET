Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Articles.WorkingWithCalculationEngine
    ' ExStart:ICustomFunction
    Public Class CustomFunction
        Implements ICustomFunction

        Public Function CalculateCustomFunction(ByVal functionName As String, ByVal paramsList As System.Collections.ArrayList, ByVal contextObjects As System.Collections.ArrayList) As Object Implements ICustomFunction.CalculateCustomFunction
            ' Get value of first parameter
            Dim firstParamB1 As Decimal = System.Convert.ToDecimal(paramsList(0))

            ' Get value of second parameter
            Dim secondParamC1C5 As Array = CType(paramsList(1), Array)

            Dim total As Decimal = 0D

            ' get every item value of second parameter
            For Each value As Object() In secondParamC1C5
                total += System.Convert.ToDecimal(value(0))
            Next value

            total = total / firstParamB1

            ' Return result of the function
            Return total
        End Function
    End Class
    ' ExEnd:ICustomFunction

    Public Class UsingICustomFunctionfeature
        Public Shared Sub Run()
            ' ExStart:UsingICustomFunctionFeature
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Open the workbook
            Dim workbook As New Workbook()

            ' Obtaining the reference of the first worksheet
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            ' Adding sample values to cells
            worksheet.Cells("B1").PutValue(5)
            worksheet.Cells("C1").PutValue(100)
            worksheet.Cells("C2").PutValue(150)
            worksheet.Cells("C3").PutValue(60)
            worksheet.Cells("C4").PutValue(32)
            worksheet.Cells("C5").PutValue(62)

            ' Adding custom formula to Cell A1
            workbook.Worksheets(0).Cells("A1").Formula = "=MyFunc(B1,C1:C5)"

            ' Calcualting Formulas
            workbook.CalculateFormula(False, New CustomFunction())

            ' Assign resultant value to Cell A1
            workbook.Worksheets(0).Cells("A1").PutValue(workbook.Worksheets(0).Cells("A1").Value)

            ' Save the file
            workbook.Save(dataDir & "output.xls")
            ' ExEnd:UsingICustomFunctionFeature
        End Sub
    End Class
End Namespace
