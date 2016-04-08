<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clipboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clipboard))
        Me.ClipboardTextBox = New System.Windows.Forms.TextBox()
        Me.FunctionMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClipboardTextBox
        '
        Me.ClipboardTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ClipboardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClipboardTextBox.ContextMenuStrip = Me.FunctionMenuStrip
        Me.ClipboardTextBox.Location = New System.Drawing.Point(12, 12)
        Me.ClipboardTextBox.Multiline = True
        Me.ClipboardTextBox.Name = "ClipboardTextBox"
        Me.ClipboardTextBox.ReadOnly = True
        Me.ClipboardTextBox.Size = New System.Drawing.Size(370, 302)
        Me.ClipboardTextBox.TabIndex = 0
        '
        'FunctionMenuStrip
        '
        Me.FunctionMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FunctionMenuStrip.Name = "FunctionMenuStrip"
        Me.FunctionMenuStrip.Size = New System.Drawing.Size(114, 48)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'Clipboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 326)
        Me.Controls.Add(Me.ClipboardTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clipboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FunctionMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClipboardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FunctionMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
