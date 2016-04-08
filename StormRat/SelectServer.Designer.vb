<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectServer
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
        Me.FromTextBox = New System.Windows.Forms.TextBox()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.ToTextBox = New System.Windows.Forms.TextBox()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FromTextBox
        '
        Me.FromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FromTextBox.Location = New System.Drawing.Point(12, 13)
        Me.FromTextBox.Name = "FromTextBox"
        Me.FromTextBox.Size = New System.Drawing.Size(104, 22)
        Me.FromTextBox.TabIndex = 0
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = True
        Me.ToLabel.Location = New System.Drawing.Point(122, 17)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(18, 13)
        Me.ToLabel.TabIndex = 1
        Me.ToLabel.Text = "to"
        '
        'ToTextBox
        '
        Me.ToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToTextBox.Location = New System.Drawing.Point(146, 13)
        Me.ToTextBox.Name = "ToTextBox"
        Me.ToTextBox.Size = New System.Drawing.Size(105, 22)
        Me.ToTextBox.TabIndex = 2
        '
        'SelectButton
        '
        Me.SelectButton.Location = New System.Drawing.Point(257, 12)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectButton.TabIndex = 3
        Me.SelectButton.Text = "Select"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'SelectServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 47)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.ToTextBox)
        Me.Controls.Add(Me.ToLabel)
        Me.Controls.Add(Me.FromTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectServer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToLabel As System.Windows.Forms.Label
    Friend WithEvents ToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SelectButton As System.Windows.Forms.Button
End Class
