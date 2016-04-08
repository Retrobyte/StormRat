<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileManager))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("AppData", 2)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Desktop", 2)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Favorites", 2)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MyDocuments", 2)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MyMusic", 2)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MyPictures", 2)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Program Files", 2)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Recent", 2)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Start Menu", 2)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Startup", 2)
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.FunctionMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorruptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.QuickListView = New StormRat.AeroListView()
        Me.QuickHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileManagerListView = New StormRat.AeroListView()
        Me.FileNameColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileSizeColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FunctionMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'LocationTextBox
        '
        Me.LocationTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LocationTextBox.Location = New System.Drawing.Point(136, 12)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.ReadOnly = True
        Me.LocationTextBox.Size = New System.Drawing.Size(275, 22)
        Me.LocationTextBox.TabIndex = 1
        '
        'UpButton
        '
        Me.UpButton.Image = CType(resources.GetObject("UpButton.Image"), System.Drawing.Image)
        Me.UpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpButton.Location = New System.Drawing.Point(417, 10)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(75, 23)
        Me.UpButton.TabIndex = 2
        Me.UpButton.Text = "Up"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'FunctionMenuStrip
        '
        Me.FunctionMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadToolStripMenuItem, Me.UploadToolStripMenuItem, Me.RenameToolStripMenuItem, Me.ExecuteToolStripMenuItem, Me.CorruptToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.FunctionMenuStrip.Name = "FunctionMenuStrip"
        Me.FunctionMenuStrip.Size = New System.Drawing.Size(129, 136)
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.Image = CType(resources.GetObject("DownloadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DownloadToolStripMenuItem.Text = "Download"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Image = CType(resources.GetObject("UploadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UploadToolStripMenuItem.Text = "Upload"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Image = CType(resources.GetObject("RenameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'ExecuteToolStripMenuItem
        '
        Me.ExecuteToolStripMenuItem.Image = CType(resources.GetObject("ExecuteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExecuteToolStripMenuItem.Name = "ExecuteToolStripMenuItem"
        Me.ExecuteToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ExecuteToolStripMenuItem.Text = "Execute"
        '
        'CorruptToolStripMenuItem
        '
        Me.CorruptToolStripMenuItem.Image = CType(resources.GetObject("CorruptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CorruptToolStripMenuItem.Name = "CorruptToolStripMenuItem"
        Me.CorruptToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CorruptToolStripMenuItem.Text = "Corrupt"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'TypeImageList
        '
        Me.TypeImageList.ImageStream = CType(resources.GetObject("TypeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TypeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TypeImageList.Images.SetKeyName(0, "drive.png")
        Me.TypeImageList.Images.SetKeyName(1, "drive_cd.png")
        Me.TypeImageList.Images.SetKeyName(2, "folder.png")
        Me.TypeImageList.Images.SetKeyName(3, "application_xp.png")
        Me.TypeImageList.Images.SetKeyName(4, "picture.png")
        Me.TypeImageList.Images.SetKeyName(5, "page_white_text.png")
        Me.TypeImageList.Images.SetKeyName(6, "cog.png")
        Me.TypeImageList.Images.SetKeyName(7, "page_white_compressed.png")
        Me.TypeImageList.Images.SetKeyName(8, "page_white.png")
        '
        'QuickListView
        '
        Me.QuickListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuickListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.QuickHeader})
        Me.QuickListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.QuickListView.Location = New System.Drawing.Point(12, 12)
        Me.QuickListView.MultiSelect = False
        Me.QuickListView.Name = "QuickListView"
        Me.QuickListView.Size = New System.Drawing.Size(118, 291)
        Me.QuickListView.SmallImageList = Me.TypeImageList
        Me.QuickListView.TabIndex = 0
        Me.QuickListView.UseCompatibleStateImageBehavior = False
        Me.QuickListView.View = System.Windows.Forms.View.Details
        '
        'QuickHeader
        '
        Me.QuickHeader.Text = "Quick Access"
        Me.QuickHeader.Width = 99
        '
        'FileManagerListView
        '
        Me.FileManagerListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileManagerListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileNameColumnHeader, Me.FileSizeColumnHeader})
        Me.FileManagerListView.ContextMenuStrip = Me.FunctionMenuStrip
        Me.FileManagerListView.FullRowSelect = True
        Me.FileManagerListView.Location = New System.Drawing.Point(136, 40)
        Me.FileManagerListView.Name = "FileManagerListView"
        Me.FileManagerListView.Size = New System.Drawing.Size(356, 263)
        Me.FileManagerListView.SmallImageList = Me.TypeImageList
        Me.FileManagerListView.TabIndex = 3
        Me.FileManagerListView.UseCompatibleStateImageBehavior = False
        Me.FileManagerListView.View = System.Windows.Forms.View.Details
        '
        'FileNameColumnHeader
        '
        Me.FileNameColumnHeader.Text = "File Name"
        Me.FileNameColumnHeader.Width = 241
        '
        'FileSizeColumnHeader
        '
        Me.FileSizeColumnHeader.Text = "File Size"
        Me.FileSizeColumnHeader.Width = 96
        '
        'FileManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 315)
        Me.Controls.Add(Me.QuickListView)
        Me.Controls.Add(Me.FileManagerListView)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileManager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FunctionMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpButton As System.Windows.Forms.Button
    Friend WithEvents FileManagerListView As StormRat.AeroListView
    Friend WithEvents FileNameColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents FileSizeColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents FunctionMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TypeImageList As System.Windows.Forms.ImageList
    Friend WithEvents QuickListView As StormRat.AeroListView
    Friend WithEvents QuickHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents DownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExecuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorruptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
