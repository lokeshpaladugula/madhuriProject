<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Abstract_btn = New System.Windows.Forms.Button()
        Me.Proceed_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Abstract_btn
        '
        Me.Abstract_btn.Location = New System.Drawing.Point(105, 91)
        Me.Abstract_btn.Name = "Abstract_btn"
        Me.Abstract_btn.Size = New System.Drawing.Size(75, 23)
        Me.Abstract_btn.TabIndex = 0
        Me.Abstract_btn.Text = "Abstract"
        Me.Abstract_btn.UseVisualStyleBackColor = True
        '
        'Proceed_btn
        '
        Me.Proceed_btn.Location = New System.Drawing.Point(356, 91)
        Me.Proceed_btn.Name = "Proceed_btn"
        Me.Proceed_btn.Size = New System.Drawing.Size(75, 23)
        Me.Proceed_btn.TabIndex = 1
        Me.Proceed_btn.Text = "Proceed"
        Me.Proceed_btn.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.Location = New System.Drawing.Point(230, 199)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Exit_btn.TabIndex = 2
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 281)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Proceed_btn)
        Me.Controls.Add(Me.Abstract_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Abstract_btn As System.Windows.Forms.Button
    Friend WithEvents Proceed_btn As System.Windows.Forms.Button
    Friend WithEvents Exit_btn As System.Windows.Forms.Button

End Class
