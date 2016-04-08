<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download
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
        Me.DownloadLabel = New System.Windows.Forms.Label()
        Me.DownloadTextBox = New System.Windows.Forms.TextBox()
        Me.FilenameLabel = New System.Windows.Forms.Label()
        Me.FilenameTextBox = New System.Windows.Forms.TextBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DownloadLabel
        '
        Me.DownloadLabel.AutoSize = True
        Me.DownloadLabel.Location = New System.Drawing.Point(9, 14)
        Me.DownloadLabel.Name = "DownloadLabel"
        Me.DownloadLabel.Size = New System.Drawing.Size(88, 13)
        Me.DownloadLabel.TabIndex = 0
        Me.DownloadLabel.Text = "Download Link:"
        '
        'DownloadTextBox
        '
        Me.DownloadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DownloadTextBox.Location = New System.Drawing.Point(103, 12)
        Me.DownloadTextBox.Name = "DownloadTextBox"
        Me.DownloadTextBox.Size = New System.Drawing.Size(169, 22)
        Me.DownloadTextBox.TabIndex = 1
        '
        'FilenameLabel
        '
        Me.FilenameLabel.AutoSize = True
        Me.FilenameLabel.Location = New System.Drawing.Point(9, 42)
        Me.FilenameLabel.Name = "FilenameLabel"
        Me.FilenameLabel.Size = New System.Drawing.Size(56, 13)
        Me.FilenameLabel.TabIndex = 2
        Me.FilenameLabel.Text = "Filename:"
        '
        'FilenameTextBox
        '
        Me.FilenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilenameTextBox.Location = New System.Drawing.Point(103, 40)
        Me.FilenameTextBox.Name = "FilenameTextBox"
        Me.FilenameTextBox.Size = New System.Drawing.Size(169, 22)
        Me.FilenameTextBox.TabIndex = 3
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(12, 68)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(260, 23)
        Me.OkButton.TabIndex = 4
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'Download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 103)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.FilenameTextBox)
        Me.Controls.Add(Me.FilenameLabel)
        Me.Controls.Add(Me.DownloadTextBox)
        Me.Controls.Add(Me.DownloadLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Download"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DownloadLabel As System.Windows.Forms.Label
    Friend WithEvents DownloadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FilenameLabel As System.Windows.Forms.Label
    Friend WithEvents FilenameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OkButton As System.Windows.Forms.Button
End Class
