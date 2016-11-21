Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System

Namespace SmartMarkers
    Public Class UsingNestedObjects
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            ' ****** Program ******

            ' Initialize WorkbookDesigner object
            Dim designer As New WorkbookDesigner()
            ' Load the template file
            designer.Workbook = New Workbook(dataDir & "SM_NestedObjects.xlsx")
            ' Instantiate the List based on the class
            Dim list As System.Collections.Generic.ICollection(Of Individual) = New System.Collections.Generic.List(Of Individual)()
            ' Create an object for the Individual class
            Dim p1 As New Individual("Damian", 30)
            ' Create the relevant Wife class for the Individual
            p1.Wife = New Wife("Dalya", 28)
            ' Create another object for the Individual class
            Dim p2 As New Individual("Mack", 31)
            ' Create the relevant Wife class for the Individual
            p2.Wife = New Wife("Maaria", 29)
            ' Add the objects to the list
            list.Add(p1)
            list.Add(p2)
            ' Specify the DataSource
            designer.SetDataSource("Individual", list)
            ' Process the markers
            designer.Process(False)
            ' Save the Excel file.
            designer.Workbook.Save(dataDir & "NestedObjects.output.xlsx")
            ' ExEnd:1

        End Sub


        Private Class Individual

            Private m_Name As String

            Public Property Name() As String
                Get
                    Return m_Name
                End Get
                Set(ByVal value As String)
                    m_Name = value
                End Set
            End Property
            Private m_Age As Integer

            Public Property Age() As Integer
                Get
                    Return m_Age
                End Get
                Set(ByVal value As Integer)
                    m_Age = value
                End Set
            End Property
            Friend Sub New(ByVal name As String, ByVal age As Integer)
                Me.Name = name
                Me.Age = age
            End Sub
            Private m_Wife As Wife

            Public Property Wife() As Wife
                Get
                    Return m_Wife
                End Get
                Set(ByVal value As Wife)
                    m_Wife = value
                End Set
            End Property

        End Class
        Public Class Wife
            Public Sub New(ByVal name As String, ByVal age As Integer)
                Me.m_name = name
                Me.m_age = age
            End Sub

            Private m_name As String

            Public Property Name() As String
                Get
                    Return m_name
                End Get
                Set(ByVal value As String)
                    m_name = value
                End Set
            End Property
            Private m_age As Integer

            Public Property Age() As Integer
                Get
                    Return m_age
                End Get
                Set(ByVal value As Integer)
                    m_age = value
                End Set
            End Property
        End Class


    End Class
End Namespace
