Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Namespace DXSample
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
            Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            DirectCast(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' lookUpEdit1
            ' 
            Me.lookUpEdit1.Location = New System.Drawing.Point(227, 81)
            Me.lookUpEdit1.Name = "lookUpEdit1"
            Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { _
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), _
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ParentID", "Parent ID", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), _
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Text", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), _
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dt", "Dt", 21, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", True, DevExpress.Utils.HorzAlignment.Near), _
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Image", "Image", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center) _
            })
            Me.lookUpEdit1.Properties.DataSource = Me.recordBindingSource
            Me.lookUpEdit1.Properties.DisplayMember = "Text"
            Me.lookUpEdit1.Properties.DropDownRows = 20
            Me.lookUpEdit1.Properties.ValueMember = "ID"
            Me.lookUpEdit1.Size = New System.Drawing.Size(428, 20)
            Me.lookUpEdit1.TabIndex = 0
            ' 
            ' recordBindingSource
            ' 
            Me.recordBindingSource.DataSource = GetType(DXSample.Data.Record)
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(892, 267)
            Me.Controls.Add(Me.lookUpEdit1)
            Me.Name = "Main"
            Me.Text = "Main"
            DirectCast(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private recordBindingSource As System.Windows.Forms.BindingSource
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit

    End Class
End Namespace