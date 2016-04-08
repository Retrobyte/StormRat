<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatSystem
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
        Me.ChatTextBox = New System.Windows.Forms.TextBox()
        Me.SendTextBox = New System.Windows.Forms.TextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChatTextBox
        '
        Me.ChatTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChatTextBox.Location = New System.Drawing.Point(12, 12)
        Me.ChatTextBox.Multiline = True
        Me.ChatTextBox.Name = "ChatTextBox"
        Me.ChatTextBox.ReadOnly = True
        Me.ChatTextBox.Size = New System.Drawing.Size(370, 273)
        Me.ChatTextBox.TabIndex = 0
        '
        'SendTextBox
        '
        Me.SendTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SendTextBox.Location = New System.Drawing.Point(12, 292)
        Me.SendTextBox.Name = "SendTextBox"
        Me.SendTextBox.Size = New System.Drawing.Size(289, 22)
        Me.SendTextBox.TabIndex = 1
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(307, 291)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 23)
        Me.SendButton.TabIndex = 2
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'ChatSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 326)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.SendTextBox)
        Me.Controls.Add(Me.ChatTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChatSystem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SendButton As System.Windows.Forms.Button
End Class
