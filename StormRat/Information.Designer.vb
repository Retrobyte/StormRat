<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Information
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
        Me.ComputerNameLabel = New System.Windows.Forms.Label()
        Me.ComputerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.IPLabel = New System.Windows.Forms.Label()
        Me.IPTextBox = New System.Windows.Forms.TextBox()
        Me.OSLabel = New System.Windows.Forms.Label()
        Me.OSTextBox = New System.Windows.Forms.TextBox()
        Me.RamLabel = New System.Windows.Forms.Label()
        Me.RamTextBox = New System.Windows.Forms.TextBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.VersionTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComputerNameLabel
        '
        Me.ComputerNameLabel.AutoSize = True
        Me.ComputerNameLabel.Location = New System.Drawing.Point(9, 14)
        Me.ComputerNameLabel.Name = "ComputerNameLabel"
        Me.ComputerNameLabel.Size = New System.Drawing.Size(93, 13)
        Me.ComputerNameLabel.TabIndex = 0
        Me.ComputerNameLabel.Text = "Computer Name:"
        '
        'ComputerNameTextBox
        '
        Me.ComputerNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ComputerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ComputerNameTextBox.Location = New System.Drawing.Point(108, 12)
        Me.ComputerNameTextBox.Name = "ComputerNameTextBox"
        Me.ComputerNameTextBox.ReadOnly = True
        Me.ComputerNameTextBox.Size = New System.Drawing.Size(164, 22)
        Me.ComputerNameTextBox.TabIndex = 1
        '
        'CountryLabel
        '
        Me.CountryLabel.AutoSize = True
        Me.CountryLabel.Location = New System.Drawing.Point(9, 42)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(51, 13)
        Me.CountryLabel.TabIndex = 2
        Me.CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CountryTextBox.Location = New System.Drawing.Point(108, 40)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.ReadOnly = True
        Me.CountryTextBox.Size = New System.Drawing.Size(164, 22)
        Me.CountryTextBox.TabIndex = 3
        '
        'IPLabel
        '
        Me.IPLabel.AutoSize = True
        Me.IPLabel.Location = New System.Drawing.Point(9, 70)
        Me.IPLabel.Name = "IPLabel"
        Me.IPLabel.Size = New System.Drawing.Size(63, 13)
        Me.IPLabel.TabIndex = 4
        Me.IPLabel.Text = "IP Address:"
        '
        'IPTextBox
        '
        Me.IPTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.IPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IPTextBox.Location = New System.Drawing.Point(108, 68)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.ReadOnly = True
        Me.IPTextBox.Size = New System.Drawing.Size(164, 22)
        Me.IPTextBox.TabIndex = 5
        '
        'OSLabel
        '
        Me.OSLabel.AutoSize = True
        Me.OSLabel.Location = New System.Drawing.Point(9, 98)
        Me.OSLabel.Name = "OSLabel"
        Me.OSLabel.Size = New System.Drawing.Size(25, 13)
        Me.OSLabel.TabIndex = 6
        Me.OSLabel.Text = "OS:"
        '
        'OSTextBox
        '
        Me.OSTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.OSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OSTextBox.Location = New System.Drawing.Point(108, 96)
        Me.OSTextBox.Name = "OSTextBox"
        Me.OSTextBox.ReadOnly = True
        Me.OSTextBox.Size = New System.Drawing.Size(164, 22)
        Me.OSTextBox.TabIndex = 7
        '
        'RamLabel
        '
        Me.RamLabel.AutoSize = True
        Me.RamLabel.Location = New System.Drawing.Point(9, 126)
        Me.RamLabel.Name = "RamLabel"
        Me.RamLabel.Size = New System.Drawing.Size(32, 13)
        Me.RamLabel.TabIndex = 8
        Me.RamLabel.Text = "Ram:"
        '
        'RamTextBox
        '
        Me.RamTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.RamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RamTextBox.Location = New System.Drawing.Point(108, 124)
        Me.RamTextBox.Name = "RamTextBox"
        Me.RamTextBox.ReadOnly = True
        Me.RamTextBox.Size = New System.Drawing.Size(164, 22)
        Me.RamTextBox.TabIndex = 9
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(9, 154)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(49, 13)
        Me.VersionLabel.TabIndex = 10
        Me.VersionLabel.Text = "Version:"
        '
        'VersionTextBox
        '
        Me.VersionTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.VersionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VersionTextBox.Location = New System.Drawing.Point(108, 152)
        Me.VersionTextBox.Name = "VersionTextBox"
        Me.VersionTextBox.ReadOnly = True
        Me.VersionTextBox.Size = New System.Drawing.Size(164, 22)
        Me.VersionTextBox.TabIndex = 11
        '
        'Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 186)
        Me.Controls.Add(Me.VersionTextBox)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.RamTextBox)
        Me.Controls.Add(Me.RamLabel)
        Me.Controls.Add(Me.OSTextBox)
        Me.Controls.Add(Me.OSLabel)
        Me.Controls.Add(Me.IPTextBox)
        Me.Controls.Add(Me.IPLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.CountryLabel)
        Me.Controls.Add(Me.ComputerNameTextBox)
        Me.Controls.Add(Me.ComputerNameLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Information"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComputerNameLabel As System.Windows.Forms.Label
    Friend WithEvents ComputerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryLabel As System.Windows.Forms.Label
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPLabel As System.Windows.Forms.Label
    Friend WithEvents IPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OSLabel As System.Windows.Forms.Label
    Friend WithEvents OSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RamLabel As System.Windows.Forms.Label
    Friend WithEvents RamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents VersionTextBox As System.Windows.Forms.TextBox
End Class
