<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessManager))
        Me.ProcessListView = New StormRat.AeroListView()
        Me.ProcessNameColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PIDColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CPUColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WindowTitleColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FunctionMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.FunctionMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcessListView
        '
        Me.ProcessListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProcessListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProcessNameColumnHeader, Me.PIDColumnHeader, Me.CPUColumnHeader, Me.WindowTitleColumnHeader})
        Me.ProcessListView.ContextMenuStrip = Me.FunctionMenuStrip
        Me.ProcessListView.FullRowSelect = True
        Me.ProcessListView.Location = New System.Drawing.Point(12, 12)
        Me.ProcessListView.Name = "ProcessListView"
        Me.ProcessListView.Size = New System.Drawing.Size(370, 352)
        Me.ProcessListView.SmallImageList = Me.ProcessImageList
        Me.ProcessListView.TabIndex = 0
        Me.ProcessListView.UseCompatibleStateImageBehavior = False
        Me.ProcessListView.View = System.Windows.Forms.View.Details
        '
        'ProcessNameColumnHeader
        '
        Me.ProcessNameColumnHeader.Text = "Process Name"
        Me.ProcessNameColumnHeader.Width = 100
        '
        'PIDColumnHeader
        '
        Me.PIDColumnHeader.Text = "PID"
        '
        'CPUColumnHeader
        '
        Me.CPUColumnHeader.Text = "CPU"
        '
        'WindowTitleColumnHeader
        '
        Me.WindowTitleColumnHeader.Text = "Window Title"
        Me.WindowTitleColumnHeader.Width = 131
        '
        'FunctionMenuStrip
        '
        Me.FunctionMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ResumeToolStripMenuItem, Me.SuspendToolStripMenuItem, Me.KillToolStripMenuItem})
        Me.FunctionMenuStrip.Name = "FunctionMenuStrip"
        Me.FunctionMenuStrip.Size = New System.Drawing.Size(120, 92)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ResumeToolStripMenuItem
        '
        Me.ResumeToolStripMenuItem.Image = CType(resources.GetObject("ResumeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResumeToolStripMenuItem.Name = "ResumeToolStripMenuItem"
        Me.ResumeToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ResumeToolStripMenuItem.Text = "Resume"
        '
        'SuspendToolStripMenuItem
        '
        Me.SuspendToolStripMenuItem.Image = CType(resources.GetObject("SuspendToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuspendToolStripMenuItem.Name = "SuspendToolStripMenuItem"
        Me.SuspendToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SuspendToolStripMenuItem.Text = "Suspend"
        '
        'KillToolStripMenuItem
        '
        Me.KillToolStripMenuItem.Image = CType(resources.GetObject("KillToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KillToolStripMenuItem.Name = "KillToolStripMenuItem"
        Me.KillToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.KillToolStripMenuItem.Text = "Kill"
        '
        'ProcessImageList
        '
        Me.ProcessImageList.ImageStream = CType(resources.GetObject("ProcessImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ProcessImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ProcessImageList.Images.SetKeyName(0, "application_xp.png")
        '
        'ProcessManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 376)
        Me.Controls.Add(Me.ProcessListView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProcessManager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FunctionMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProcessListView As StormRat.AeroListView
    Friend WithEvents ProcessNameColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents PIDColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents CPUColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents WindowTitleColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents FunctionMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessImageList As System.Windows.Forms.ImageList
End Class
