Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq

Namespace DXSample.Data
    Public Class Record
        Public Sub New()
        End Sub
        Public Property ID() As Integer
        Public Property ParentID() As Integer?
        Public Property Text() As String
        Public Property Info() As String
        Public Property Value() As Double
        Public Property Dt() As Date
        Public Property State() As Boolean
        Public Property Image() As Image
        Public Property Details() As BindingList(Of Detail)
        Public Overrides Function ToString() As String
            Return String.Format("ID = {0}, Text = {1}", ID, Text)
        End Function
        Public Property Detail() As Detail

    End Class
    Public Class Detail
        Public Sub New()
            Details = New BindingList(Of Detail)()
        End Sub
        Public Property ID() As Integer
        Public Property Text() As String
        Public Property Info() As String
        Public Property Details() As BindingList(Of Detail)
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Public Class DataHelper
        Public Shared Function GetData(ByVal count As Integer, ByVal detailCount As Integer) As BindingList(Of Record)
            Dim records As New BindingList(Of Record)()
            Dim details As New BindingList(Of Detail)()
            Dim testDetails As New BindingList(Of Detail)()
            For j As Integer = 0 To detailCount - 1
                details.Add(New Detail() With {.ID = j, .Text = String.Format("Text {0}", j), .Info = String.Format("Info {0}", j)})
                testDetails.Add(New Detail() With {.ID = j, .Text = String.Format("Test Text {0}", j), .Info = String.Format(" Test Info {0}", j)})
            Next j
            For i As Integer = 0 To count - 1
                records.Add(New Record() With { _
                    .ParentID = -1, .ID = i, .Text = String.Format("Text {0}", i), .Info = String.Format("Info {0}", i), .Dt = Date.Now.AddDays(i), .State = i Mod 2 = 0, .Image = SystemIcons.Information.ToBitmap(), .Details = New BindingList(Of Detail)(details), .Value = i * 0.00001, .Detail = New Detail() With {.ID = i, .Text = String.Format("Text {0}", i)} _
                })
            Next i

            Return records
        End Function
        Public Shared Function GetData(ByVal count As Integer) As BindingList(Of Record)
            Dim records As New BindingList(Of Record)()
            For i As Integer = 0 To count - 1
                records.Add(New Record() With { _
                    .ID = i, .ParentID = i Mod 5, .Text = String.Format("Text {0}", i), .Info = String.Format("Info {0}", i), .Dt = Date.Now.AddDays(i), .Value = 10.1 * i, .State = False, .Image = SystemIcons.Information.ToBitmap(), .Detail = New Detail() With {.ID = i} _
                })
            Next i
            Return records
        End Function
        Public Shared Function GetDetailData(ByVal count As Integer) As BindingList(Of Detail)
            Dim records As New BindingList(Of Detail)()
            For i As Integer = 0 To count - 1
                records.Add(New Detail() With {.ID = i, .Text = String.Format("Text {0}", i), .Info = String.Format("Info {0}", i)})
            Next i
            Return records
        End Function
    End Class
End Namespace
