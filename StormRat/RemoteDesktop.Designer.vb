<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteDesktop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteDesktop))
        Me.SettingsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopPictureBox = New System.Windows.Forms.PictureBox()
        Me.SettingsMenuStrip.SuspendLayout()
        CType(Me.DesktopPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SettingsMenuStrip
        '
        Me.SettingsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.SettingsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.SettingsMenuStrip.Name = "SettingsMenuStrip"
        Me.SettingsMenuStrip.Size = New System.Drawing.Size(565, 24)
        Me.SettingsMenuStrip.TabIndex = 0
        Me.SettingsMenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeyboardToolStripMenuItem, Me.MouseToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'KeyboardToolStripMenuItem
        '
        Me.KeyboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableToolStripMenuItem, Me.DisableToolStripMenuItem})
        Me.KeyboardToolStripMenuItem.Image = CType(resources.GetObject("KeyboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeyboardToolStripMenuItem.Name = "KeyboardToolStripMenuItem"
        Me.KeyboardToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeyboardToolStripMenuItem.Text = "Keyboard"
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Image = CType(resources.GetObject("EnableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.Enabled = False
        Me.DisableToolStripMenuItem.Image = CType(resources.GetObject("DisableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisableToolStripMenuItem.Name = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'MouseToolStripMenuItem
        '
        Me.MouseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HoverToolStripMenuItem, Me.ClickToolStripMenuItem})
        Me.MouseToolStripMenuItem.Image = CType(resources.GetObject("MouseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MouseToolStripMenuItem.Name = "MouseToolStripMenuItem"
        Me.MouseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MouseToolStripMenuItem.Text = "Mouse"
        '
        'HoverToolStripMenuItem
        '
        Me.HoverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableToolStripMenuItem1, Me.DisableToolStripMenuItem1})
        Me.HoverToolStripMenuItem.Image = CType(resources.GetObject("HoverToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HoverToolStripMenuItem.Name = "HoverToolStripMenuItem"
        Me.HoverToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HoverToolStripMenuItem.Text = "Hover"
        '
        'EnableToolStripMenuItem1
        '
        Me.EnableToolStripMenuItem1.Image = CType(resources.GetObject("EnableToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EnableToolStripMenuItem1.Name = "EnableToolStripMenuItem1"
        Me.EnableToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EnableToolStripMenuItem1.Text = "Enable"
        '
        'DisableToolStripMenuItem1
        '
        Me.DisableToolStripMenuItem1.Enabled = False
        Me.DisableToolStripMenuItem1.Image = CType(resources.GetObject("DisableToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DisableToolStripMenuItem1.Name = "DisableToolStripMenuItem1"
        Me.DisableToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DisableToolStripMenuItem1.Text = "Disable"
        '
        'ClickToolStripMenuItem
        '
        Me.ClickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableToolStripMenuItem2, Me.DisableToolStripMenuItem2})
        Me.ClickToolStripMenuItem.Image = CType(resources.GetObject("ClickToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClickToolStripMenuItem.Name = "ClickToolStripMenuItem"
        Me.ClickToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClickToolStripMenuItem.Text = "Click"
        '
        'EnableToolStripMenuItem2
        '
        Me.EnableToolStripMenuItem2.Image = CType(resources.GetObject("EnableToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.EnableToolStripMenuItem2.Name = "EnableToolStripMenuItem2"
        Me.EnableToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.EnableToolStripMenuItem2.Text = "Enable"
        '
        'DisableToolStripMenuItem2
        '
        Me.DisableToolStripMenuItem2.Enabled = False
        Me.DisableToolStripMenuItem2.Image = CType(resources.GetObject("DisableToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.DisableToolStripMenuItem2.Name = "DisableToolStripMenuItem2"
        Me.DisableToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.DisableToolStripMenuItem2.Text = "Disable"
        '
        'DesktopPictureBox
        '
        Me.DesktopPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopPictureBox.Location = New System.Drawing.Point(0, 24)
        Me.DesktopPictureBox.Name = "DesktopPictureBox"
        Me.DesktopPictureBox.Size = New System.Drawing.Size(565, 360)
        Me.DesktopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DesktopPictureBox.TabIndex = 1
        Me.DesktopPictureBox.TabStop = False
        '
        'RemoteDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 384)
        Me.Controls.Add(Me.DesktopPictureBox)
        Me.Controls.Add(Me.SettingsMenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.SettingsMenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoteDesktop"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.SettingsMenuStrip.ResumeLayout(False)
        Me.SettingsMenuStrip.PerformLayout()
        CType(Me.DesktopPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SettingsMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesktopPictureBox As System.Windows.Forms.PictureBox
End Class
