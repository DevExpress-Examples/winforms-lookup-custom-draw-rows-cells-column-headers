Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DXSample.Data

Namespace DXSample

    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            recordBindingSource.DataSource = DataHelper.GetData(50)
        End Sub
        Private Sub OnCustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Popup.LookUpCustomDrawCellArgs) Handles lookUpEdit1.CustomDrawCell
            Dim edit As LookUpEdit = TryCast(sender, LookUpEdit)
            If IsServiceColumn(edit, e.Column.FieldName) Then
                e.Appearance.BackColor = Color.Blue
                e.Appearance.ForeColor = Color.White
            End If
        End Sub
        Private Function IsServiceColumn(ByVal edit As LookUpEdit, ByVal fieldName As String) As Boolean
            Return fieldName = edit.Properties.ValueMember OrElse fieldName = edit.Properties.DisplayMember
        End Function
        Private Sub OnCustomDrawHeader(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Popup.LookUpCustomDrawHeaderArgs) Handles lookUpEdit1.CustomDrawHeader
            Dim edit As LookUpEdit = TryCast(sender, LookUpEdit)
            If IsServiceColumn(edit, e.Header.Column.FieldName) Then
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds)
                e.Graphics.DrawString(e.Header.Caption, e.Header.Appearance.Font, Brushes.White, e.Header.CaptionRect)
                e.Handled = True
            End If
        End Sub
        Private Sub OnCustomDrawRow(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Popup.LookUpCustomDrawRowArgs) Handles lookUpEdit1.CustomDrawRow
            If e.IsSelected Then
                Using brush As New HatchBrush(HatchStyle.Weave, Color.FromArgb(30, Color.Orange), Color.FromArgb(120, Color.White))
                    e.DefaultDraw()
                    e.Cache.FillRectangle(brush, e.Bounds)
                    e.Handled = True
                End Using
            End If
        End Sub
    End Class
End Namespace