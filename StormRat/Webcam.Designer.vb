<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Webcam
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
        Me.WebcamPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.WebcamPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebcamPictureBox
        '
        Me.WebcamPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebcamPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.WebcamPictureBox.Name = "WebcamPictureBox"
        Me.WebcamPictureBox.Size = New System.Drawing.Size(480, 360)
        Me.WebcamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WebcamPictureBox.TabIndex = 0
        Me.WebcamPictureBox.TabStop = False
        '
        'Webcam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 360)
        Me.Controls.Add(Me.WebcamPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Webcam"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.WebcamPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebcamPictureBox As System.Windows.Forms.PictureBox
End Class
