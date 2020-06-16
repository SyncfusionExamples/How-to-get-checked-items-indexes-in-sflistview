<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SfListView1 = New Syncfusion.WinForms.ListView.SfListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SfListView1
        '
        Me.SfListView1.AccessibleName = "ScrollControl"
        Me.SfListView1.Location = New System.Drawing.Point(63, 43)
        Me.SfListView1.Name = "SfListView1"
        Me.SfListView1.Size = New System.Drawing.Size(353, 373)
        Me.SfListView1.TabIndex = 0
        Me.SfListView1.Text = "SfListView1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(600, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Check ListViewItems"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(600, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 53)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Uncheck SfListViewItems"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SfListView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SfListView1 As Syncfusion.WinForms.ListView.SfListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
