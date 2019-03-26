<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.openkey = New System.Windows.Forms.Button()
        Me.openmatrix = New System.Windows.Forms.Button()
        Me.shifitingcols = New System.Windows.Forms.Button()
        Me.shiftingcols2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'openkey
        '
        Me.openkey.Location = New System.Drawing.Point(29, 12)
        Me.openkey.Name = "openkey"
        Me.openkey.Size = New System.Drawing.Size(75, 23)
        Me.openkey.TabIndex = 0
        Me.openkey.Text = "openkey"
        Me.openkey.UseVisualStyleBackColor = True
        '
        'openmatrix
        '
        Me.openmatrix.Location = New System.Drawing.Point(29, 90)
        Me.openmatrix.Name = "openmatrix"
        Me.openmatrix.Size = New System.Drawing.Size(75, 23)
        Me.openmatrix.TabIndex = 1
        Me.openmatrix.Text = "open matrix"
        Me.openmatrix.UseVisualStyleBackColor = True
        '
        'shifitingcols
        '
        Me.shifitingcols.Location = New System.Drawing.Point(29, 165)
        Me.shifitingcols.Name = "shifitingcols"
        Me.shifitingcols.Size = New System.Drawing.Size(75, 23)
        Me.shifitingcols.TabIndex = 2
        Me.shifitingcols.Text = "shifting cols"
        Me.shifitingcols.UseVisualStyleBackColor = True
        '
        'shiftingcols2
        '
        Me.shiftingcols2.Location = New System.Drawing.Point(29, 373)
        Me.shiftingcols2.Name = "shiftingcols2"
        Me.shiftingcols2.Size = New System.Drawing.Size(75, 23)
        Me.shiftingcols2.TabIndex = 4
        Me.shiftingcols2.Text = "shifting cols 2"
        Me.shiftingcols2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(255, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(243, 39)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 113)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(243, 157)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 93)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(462, 182)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(276, 20)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(238, 263)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(246, 118)
        Me.TextBox5.TabIndex = 10
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(492, 450)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(246, 20)
        Me.TextBox7.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(238, 393)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(246, 118)
        Me.TextBox6.TabIndex = 12
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 534)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.shiftingcols2)
        Me.Controls.Add(Me.shifitingcols)
        Me.Controls.Add(Me.openmatrix)
        Me.Controls.Add(Me.openkey)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openkey As System.Windows.Forms.Button
    Friend WithEvents openmatrix As System.Windows.Forms.Button
    Friend WithEvents shifitingcols As System.Windows.Forms.Button
    Friend WithEvents shiftingcols2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
End Class
