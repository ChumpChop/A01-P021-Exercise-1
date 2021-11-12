<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExercise1
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
        Me.lblEnterSomeText = New System.Windows.Forms.Label()
        Me.txtEnterSomeText = New System.Windows.Forms.TextBox()
        Me.btnShowText = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterSomeText
        '
        Me.lblEnterSomeText.AutoSize = True
        Me.lblEnterSomeText.Location = New System.Drawing.Point(44, 45)
        Me.lblEnterSomeText.Name = "lblEnterSomeText"
        Me.lblEnterSomeText.Size = New System.Drawing.Size(86, 13)
        Me.lblEnterSomeText.TabIndex = 0
        Me.lblEnterSomeText.Text = "Enter Some Text"
        '
        'txtEnterSomeText
        '
        Me.txtEnterSomeText.Location = New System.Drawing.Point(136, 38)
        Me.txtEnterSomeText.Name = "txtEnterSomeText"
        Me.txtEnterSomeText.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterSomeText.TabIndex = 1
        '
        'btnShowText
        '
        Me.btnShowText.Location = New System.Drawing.Point(12, 93)
        Me.btnShowText.Name = "btnShowText"
        Me.btnShowText.Size = New System.Drawing.Size(75, 23)
        Me.btnShowText.TabIndex = 2
        Me.btnShowText.Text = "&Show Text"
        Me.btnShowText.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(220, 93)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmExercise1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 128)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowText)
        Me.Controls.Add(Me.txtEnterSomeText)
        Me.Controls.Add(Me.lblEnterSomeText)
        Me.Name = "frmExercise1"
        Me.Text = "Exercise 1 CBH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnterSomeText As Label
    Friend WithEvents txtEnterSomeText As TextBox
    Friend WithEvents btnShowText As Button
    Friend WithEvents btnExit As Button
End Class
