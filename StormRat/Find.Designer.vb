<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Find
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
        Me.FindComboBox = New System.Windows.Forms.ComboBox()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FindComboBox
        '
        Me.FindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FindComboBox.FormattingEnabled = True
        Me.FindComboBox.Items.AddRange(New Object() {"Country", "ID", "IP", "OS", "Version"})
        Me.FindComboBox.Location = New System.Drawing.Point(12, 12)
        Me.FindComboBox.Name = "FindComboBox"
        Me.FindComboBox.Size = New System.Drawing.Size(66, 21)
        Me.FindComboBox.TabIndex = 0
        '
        'FindTextBox
        '
        Me.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FindTextBox.Location = New System.Drawing.Point(84, 12)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(167, 22)
        Me.FindTextBox.TabIndex = 1
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(257, 12)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(75, 23)
        Me.FindButton.TabIndex = 2
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'Find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 47)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.FindTextBox)
        Me.Controls.Add(Me.FindComboBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Find"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FindComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FindTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FindButton As System.Windows.Forms.Button
End Class
