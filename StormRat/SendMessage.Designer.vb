<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendMessage))
        Me.IconGroupBox = New System.Windows.Forms.GroupBox()
        Me.ErrorRadioButton = New System.Windows.Forms.RadioButton()
        Me.ErrorPictureBox = New System.Windows.Forms.PictureBox()
        Me.WarningRadioButton = New System.Windows.Forms.RadioButton()
        Me.WarningPictureBox = New System.Windows.Forms.PictureBox()
        Me.QuestionRadioButton = New System.Windows.Forms.RadioButton()
        Me.QuestionPictureBox = New System.Windows.Forms.PictureBox()
        Me.InformationRadioButton = New System.Windows.Forms.RadioButton()
        Me.InformationPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContentGroupBox = New System.Windows.Forms.GroupBox()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.AbortRetryCancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.RetryCancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.OKCancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.OKRadioButton = New System.Windows.Forms.RadioButton()
        Me.YesNoCancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.YesNoRadioButton = New System.Windows.Forms.RadioButton()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.IconGroupBox.SuspendLayout()
        CType(Me.ErrorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarningPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformationPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContentGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconGroupBox
        '
        Me.IconGroupBox.Controls.Add(Me.ErrorRadioButton)
        Me.IconGroupBox.Controls.Add(Me.ErrorPictureBox)
        Me.IconGroupBox.Controls.Add(Me.WarningRadioButton)
        Me.IconGroupBox.Controls.Add(Me.WarningPictureBox)
        Me.IconGroupBox.Controls.Add(Me.QuestionRadioButton)
        Me.IconGroupBox.Controls.Add(Me.QuestionPictureBox)
        Me.IconGroupBox.Controls.Add(Me.InformationRadioButton)
        Me.IconGroupBox.Controls.Add(Me.InformationPictureBox)
        Me.IconGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.IconGroupBox.Name = "IconGroupBox"
        Me.IconGroupBox.Size = New System.Drawing.Size(397, 98)
        Me.IconGroupBox.TabIndex = 0
        Me.IconGroupBox.TabStop = False
        Me.IconGroupBox.Text = "MessageBox Icon"
        '
        'ErrorRadioButton
        '
        Me.ErrorRadioButton.AutoSize = True
        Me.ErrorRadioButton.Location = New System.Drawing.Point(317, 72)
        Me.ErrorRadioButton.Name = "ErrorRadioButton"
        Me.ErrorRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.ErrorRadioButton.TabIndex = 7
        Me.ErrorRadioButton.Text = "Error"
        Me.ErrorRadioButton.UseVisualStyleBackColor = True
        '
        'ErrorPictureBox
        '
        Me.ErrorPictureBox.Image = CType(resources.GetObject("ErrorPictureBox.Image"), System.Drawing.Image)
        Me.ErrorPictureBox.Location = New System.Drawing.Point(317, 21)
        Me.ErrorPictureBox.Name = "ErrorPictureBox"
        Me.ErrorPictureBox.Size = New System.Drawing.Size(45, 45)
        Me.ErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ErrorPictureBox.TabIndex = 6
        Me.ErrorPictureBox.TabStop = False
        '
        'WarningRadioButton
        '
        Me.WarningRadioButton.AutoSize = True
        Me.WarningRadioButton.Location = New System.Drawing.Point(212, 72)
        Me.WarningRadioButton.Name = "WarningRadioButton"
        Me.WarningRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.WarningRadioButton.TabIndex = 5
        Me.WarningRadioButton.Text = "Warning"
        Me.WarningRadioButton.UseVisualStyleBackColor = True
        '
        'WarningPictureBox
        '
        Me.WarningPictureBox.Image = CType(resources.GetObject("WarningPictureBox.Image"), System.Drawing.Image)
        Me.WarningPictureBox.Location = New System.Drawing.Point(224, 21)
        Me.WarningPictureBox.Name = "WarningPictureBox"
        Me.WarningPictureBox.Size = New System.Drawing.Size(45, 45)
        Me.WarningPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WarningPictureBox.TabIndex = 4
        Me.WarningPictureBox.TabStop = False
        '
        'QuestionRadioButton
        '
        Me.QuestionRadioButton.AutoSize = True
        Me.QuestionRadioButton.Location = New System.Drawing.Point(114, 72)
        Me.QuestionRadioButton.Name = "QuestionRadioButton"
        Me.QuestionRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.QuestionRadioButton.TabIndex = 3
        Me.QuestionRadioButton.Text = "Question"
        Me.QuestionRadioButton.UseVisualStyleBackColor = True
        '
        'QuestionPictureBox
        '
        Me.QuestionPictureBox.Image = CType(resources.GetObject("QuestionPictureBox.Image"), System.Drawing.Image)
        Me.QuestionPictureBox.Location = New System.Drawing.Point(128, 21)
        Me.QuestionPictureBox.Name = "QuestionPictureBox"
        Me.QuestionPictureBox.Size = New System.Drawing.Size(45, 45)
        Me.QuestionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuestionPictureBox.TabIndex = 2
        Me.QuestionPictureBox.TabStop = False
        '
        'InformationRadioButton
        '
        Me.InformationRadioButton.AutoSize = True
        Me.InformationRadioButton.Checked = True
        Me.InformationRadioButton.Location = New System.Drawing.Point(13, 72)
        Me.InformationRadioButton.Name = "InformationRadioButton"
        Me.InformationRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.InformationRadioButton.TabIndex = 1
        Me.InformationRadioButton.TabStop = True
        Me.InformationRadioButton.Text = "Information"
        Me.InformationRadioButton.UseVisualStyleBackColor = True
        '
        'InformationPictureBox
        '
        Me.InformationPictureBox.Image = CType(resources.GetObject("InformationPictureBox.Image"), System.Drawing.Image)
        Me.InformationPictureBox.Location = New System.Drawing.Point(34, 21)
        Me.InformationPictureBox.Name = "InformationPictureBox"
        Me.InformationPictureBox.Size = New System.Drawing.Size(45, 45)
        Me.InformationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InformationPictureBox.TabIndex = 0
        Me.InformationPictureBox.TabStop = False
        '
        'ContentGroupBox
        '
        Me.ContentGroupBox.Controls.Add(Me.MessageTextBox)
        Me.ContentGroupBox.Controls.Add(Me.TitleTextBox)
        Me.ContentGroupBox.Location = New System.Drawing.Point(12, 116)
        Me.ContentGroupBox.Name = "ContentGroupBox"
        Me.ContentGroupBox.Size = New System.Drawing.Size(249, 160)
        Me.ContentGroupBox.TabIndex = 1
        Me.ContentGroupBox.TabStop = False
        Me.ContentGroupBox.Text = "MessageBox Content"
        '
        'MessageTextBox
        '
        Me.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageTextBox.Location = New System.Drawing.Point(6, 49)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(237, 105)
        Me.MessageTextBox.TabIndex = 1
        '
        'TitleTextBox
        '
        Me.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitleTextBox.Location = New System.Drawing.Point(6, 21)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(237, 22)
        Me.TitleTextBox.TabIndex = 0
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.AbortRetryCancelRadioButton)
        Me.ButtonGroupBox.Controls.Add(Me.RetryCancelRadioButton)
        Me.ButtonGroupBox.Controls.Add(Me.OKCancelRadioButton)
        Me.ButtonGroupBox.Controls.Add(Me.OKRadioButton)
        Me.ButtonGroupBox.Controls.Add(Me.YesNoCancelRadioButton)
        Me.ButtonGroupBox.Controls.Add(Me.YesNoRadioButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(267, 116)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(142, 160)
        Me.ButtonGroupBox.TabIndex = 2
        Me.ButtonGroupBox.TabStop = False
        Me.ButtonGroupBox.Text = "MessageBox Button"
        '
        'AbortRetryCancelRadioButton
        '
        Me.AbortRetryCancelRadioButton.AutoSize = True
        Me.AbortRetryCancelRadioButton.Location = New System.Drawing.Point(6, 136)
        Me.AbortRetryCancelRadioButton.Name = "AbortRetryCancelRadioButton"
        Me.AbortRetryCancelRadioButton.Size = New System.Drawing.Size(132, 17)
        Me.AbortRetryCancelRadioButton.TabIndex = 5
        Me.AbortRetryCancelRadioButton.Text = "Abort | Retry | Ignore"
        Me.AbortRetryCancelRadioButton.UseVisualStyleBackColor = True
        '
        'RetryCancelRadioButton
        '
        Me.RetryCancelRadioButton.AutoSize = True
        Me.RetryCancelRadioButton.Location = New System.Drawing.Point(6, 113)
        Me.RetryCancelRadioButton.Name = "RetryCancelRadioButton"
        Me.RetryCancelRadioButton.Size = New System.Drawing.Size(94, 17)
        Me.RetryCancelRadioButton.TabIndex = 4
        Me.RetryCancelRadioButton.Text = "Retry | Cancel"
        Me.RetryCancelRadioButton.UseVisualStyleBackColor = True
        '
        'OKCancelRadioButton
        '
        Me.OKCancelRadioButton.AutoSize = True
        Me.OKCancelRadioButton.Location = New System.Drawing.Point(6, 90)
        Me.OKCancelRadioButton.Name = "OKCancelRadioButton"
        Me.OKCancelRadioButton.Size = New System.Drawing.Size(83, 17)
        Me.OKCancelRadioButton.TabIndex = 3
        Me.OKCancelRadioButton.Text = "OK | Cancel"
        Me.OKCancelRadioButton.UseVisualStyleBackColor = True
        '
        'OKRadioButton
        '
        Me.OKRadioButton.AutoSize = True
        Me.OKRadioButton.Location = New System.Drawing.Point(6, 67)
        Me.OKRadioButton.Name = "OKRadioButton"
        Me.OKRadioButton.Size = New System.Drawing.Size(40, 17)
        Me.OKRadioButton.TabIndex = 2
        Me.OKRadioButton.Text = "OK"
        Me.OKRadioButton.UseVisualStyleBackColor = True
        '
        'YesNoCancelRadioButton
        '
        Me.YesNoCancelRadioButton.AutoSize = True
        Me.YesNoCancelRadioButton.Location = New System.Drawing.Point(6, 44)
        Me.YesNoCancelRadioButton.Name = "YesNoCancelRadioButton"
        Me.YesNoCancelRadioButton.Size = New System.Drawing.Size(108, 17)
        Me.YesNoCancelRadioButton.TabIndex = 1
        Me.YesNoCancelRadioButton.Text = "Yes | No | Cancel"
        Me.YesNoCancelRadioButton.UseVisualStyleBackColor = True
        '
        'YesNoRadioButton
        '
        Me.YesNoRadioButton.AutoSize = True
        Me.YesNoRadioButton.Checked = True
        Me.YesNoRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.YesNoRadioButton.Name = "YesNoRadioButton"
        Me.YesNoRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.YesNoRadioButton.TabIndex = 0
        Me.YesNoRadioButton.TabStop = True
        Me.YesNoRadioButton.Text = "Yes | No"
        Me.YesNoRadioButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(12, 282)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(397, 23)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SendMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 317)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.ContentGroupBox)
        Me.Controls.Add(Me.IconGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendMessage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.IconGroupBox.ResumeLayout(False)
        Me.IconGroupBox.PerformLayout()
        CType(Me.ErrorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarningPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformationPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContentGroupBox.ResumeLayout(False)
        Me.ContentGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ButtonGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ErrorPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents WarningRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents WarningPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents QuestionPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents InformationRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents InformationPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ContentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AbortRetryCancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RetryCancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OKCancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OKRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents YesNoCancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents YesNoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
