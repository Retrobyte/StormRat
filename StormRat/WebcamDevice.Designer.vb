<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebcamDevice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebcamDevice))
        Me.WebcamListView = New StormRat.AeroListView()
        Me.WebcamListHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CamImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.StartWebcamButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebcamListView
        '
        Me.WebcamListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WebcamListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.WebcamListHeader})
        Me.WebcamListView.Location = New System.Drawing.Point(12, 12)
        Me.WebcamListView.MultiSelect = False
        Me.WebcamListView.Name = "WebcamListView"
        Me.WebcamListView.Size = New System.Drawing.Size(260, 209)
        Me.WebcamListView.SmallImageList = Me.CamImageList
        Me.WebcamListView.TabIndex = 0
        Me.WebcamListView.UseCompatibleStateImageBehavior = False
        Me.WebcamListView.View = System.Windows.Forms.View.Details
        '
        'WebcamListHeader
        '
        Me.WebcamListHeader.Text = "Webcam"
        Me.WebcamListHeader.Width = 241
        '
        'CamImageList
        '
        Me.CamImageList.ImageStream = CType(resources.GetObject("CamImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CamImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.CamImageList.Images.SetKeyName(0, "webcam.png")
        '
        'StartWebcamButton
        '
        Me.StartWebcamButton.Location = New System.Drawing.Point(12, 227)
        Me.StartWebcamButton.Name = "StartWebcamButton"
        Me.StartWebcamButton.Size = New System.Drawing.Size(260, 23)
        Me.StartWebcamButton.TabIndex = 1
        Me.StartWebcamButton.Text = "Start"
        Me.StartWebcamButton.UseVisualStyleBackColor = True
        '
        'WebcamDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.StartWebcamButton)
        Me.Controls.Add(Me.WebcamListView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WebcamDevice"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebcamListView As StormRat.AeroListView
    Friend WithEvents StartWebcamButton As System.Windows.Forms.Button
    Friend WithEvents WebcamListHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents CamImageList As System.Windows.Forms.ImageList
End Class
