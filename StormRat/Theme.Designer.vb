<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Theme
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
        Me.CustomizationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ButtonBTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonBLabel = New System.Windows.Forms.Label()
        Me.ButtonATextBox = New System.Windows.Forms.TextBox()
        Me.ButtonALabel = New System.Windows.Forms.Label()
        Me.ThemeTextBox = New System.Windows.Forms.TextBox()
        Me.ThemeLabel = New System.Windows.Forms.Label()
        Me.OtherGroupBox = New System.Windows.Forms.GroupBox()
        Me.LabelPictureBox = New System.Windows.Forms.PictureBox()
        Me.LabelLabel = New System.Windows.Forms.Label()
        Me.NoteLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CustomizationGroupBox.SuspendLayout()
        Me.OtherGroupBox.SuspendLayout()
        CType(Me.LabelPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomizationGroupBox
        '
        Me.CustomizationGroupBox.Controls.Add(Me.ButtonBTextBox)
        Me.CustomizationGroupBox.Controls.Add(Me.ButtonBLabel)
        Me.CustomizationGroupBox.Controls.Add(Me.ButtonATextBox)
        Me.CustomizationGroupBox.Controls.Add(Me.ButtonALabel)
        Me.CustomizationGroupBox.Controls.Add(Me.ThemeTextBox)
        Me.CustomizationGroupBox.Controls.Add(Me.ThemeLabel)
        Me.CustomizationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.CustomizationGroupBox.Name = "CustomizationGroupBox"
        Me.CustomizationGroupBox.Size = New System.Drawing.Size(260, 101)
        Me.CustomizationGroupBox.TabIndex = 0
        Me.CustomizationGroupBox.TabStop = False
        Me.CustomizationGroupBox.Text = "Customization"
        '
        'ButtonBTextBox
        '
        Me.ButtonBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ButtonBTextBox.Location = New System.Drawing.Point(65, 72)
        Me.ButtonBTextBox.Name = "ButtonBTextBox"
        Me.ButtonBTextBox.Size = New System.Drawing.Size(189, 22)
        Me.ButtonBTextBox.TabIndex = 5
        '
        'ButtonBLabel
        '
        Me.ButtonBLabel.AutoSize = True
        Me.ButtonBLabel.Location = New System.Drawing.Point(3, 74)
        Me.ButtonBLabel.Name = "ButtonBLabel"
        Me.ButtonBLabel.Size = New System.Drawing.Size(56, 13)
        Me.ButtonBLabel.TabIndex = 4
        Me.ButtonBLabel.Text = "Button B:"
        '
        'ButtonATextBox
        '
        Me.ButtonATextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ButtonATextBox.Location = New System.Drawing.Point(65, 44)
        Me.ButtonATextBox.Name = "ButtonATextBox"
        Me.ButtonATextBox.Size = New System.Drawing.Size(189, 22)
        Me.ButtonATextBox.TabIndex = 3
        '
        'ButtonALabel
        '
        Me.ButtonALabel.AutoSize = True
        Me.ButtonALabel.Location = New System.Drawing.Point(3, 46)
        Me.ButtonALabel.Name = "ButtonALabel"
        Me.ButtonALabel.Size = New System.Drawing.Size(56, 13)
        Me.ButtonALabel.TabIndex = 2
        Me.ButtonALabel.Text = "Button A:"
        '
        'ThemeTextBox
        '
        Me.ThemeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThemeTextBox.Location = New System.Drawing.Point(65, 16)
        Me.ThemeTextBox.Name = "ThemeTextBox"
        Me.ThemeTextBox.Size = New System.Drawing.Size(189, 22)
        Me.ThemeTextBox.TabIndex = 1
        '
        'ThemeLabel
        '
        Me.ThemeLabel.AutoSize = True
        Me.ThemeLabel.Location = New System.Drawing.Point(3, 18)
        Me.ThemeLabel.Name = "ThemeLabel"
        Me.ThemeLabel.Size = New System.Drawing.Size(43, 13)
        Me.ThemeLabel.TabIndex = 0
        Me.ThemeLabel.Text = "Theme:"
        '
        'OtherGroupBox
        '
        Me.OtherGroupBox.Controls.Add(Me.LabelPictureBox)
        Me.OtherGroupBox.Controls.Add(Me.LabelLabel)
        Me.OtherGroupBox.Location = New System.Drawing.Point(12, 119)
        Me.OtherGroupBox.Name = "OtherGroupBox"
        Me.OtherGroupBox.Size = New System.Drawing.Size(260, 45)
        Me.OtherGroupBox.TabIndex = 1
        Me.OtherGroupBox.TabStop = False
        Me.OtherGroupBox.Text = "Other"
        '
        'LabelPictureBox
        '
        Me.LabelPictureBox.BackColor = System.Drawing.Color.White
        Me.LabelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelPictureBox.Location = New System.Drawing.Point(65, 16)
        Me.LabelPictureBox.Name = "LabelPictureBox"
        Me.LabelPictureBox.Size = New System.Drawing.Size(189, 22)
        Me.LabelPictureBox.TabIndex = 1
        Me.LabelPictureBox.TabStop = False
        '
        'LabelLabel
        '
        Me.LabelLabel.AutoSize = True
        Me.LabelLabel.Location = New System.Drawing.Point(3, 18)
        Me.LabelLabel.Name = "LabelLabel"
        Me.LabelLabel.Size = New System.Drawing.Size(61, 13)
        Me.LabelLabel.TabIndex = 0
        Me.LabelLabel.Text = "Text Color:"
        '
        'NoteLabel
        '
        Me.NoteLabel.Location = New System.Drawing.Point(9, 167)
        Me.NoteLabel.Name = "NoteLabel"
        Me.NoteLabel.Size = New System.Drawing.Size(266, 13)
        Me.NoteLabel.TabIndex = 2
        Me.NoteLabel.Text = "Note: These settings are only for the main form."
        Me.NoteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(12, 183)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(260, 23)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Theme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NoteLabel)
        Me.Controls.Add(Me.OtherGroupBox)
        Me.Controls.Add(Me.CustomizationGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Theme"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theme Settings"
        Me.CustomizationGroupBox.ResumeLayout(False)
        Me.CustomizationGroupBox.PerformLayout()
        Me.OtherGroupBox.ResumeLayout(False)
        Me.OtherGroupBox.PerformLayout()
        CType(Me.LabelPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomizationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ThemeLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonALabel As System.Windows.Forms.Label
    Friend WithEvents ThemeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtherGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LabelPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelLabel As System.Windows.Forms.Label
    Friend WithEvents NoteLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
