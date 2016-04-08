Public Class Download

    Private Sub Download_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DownloadTextBox.Text = "" : FilenameTextBox.Text = "" : DownloadTextBox.Focus()
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        If DownloadTextBox.Text = "" Or FilenameTextBox.Text = "" Then
            MessageBox.Show("Please make sure all fields are filled in correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK : Me.Close()
    End Sub

    Private Sub Download_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Me.ActiveControl.Name = DownloadTextBox.Name Or Me.ActiveControl.Name = FilenameTextBox.Name Then
            If e.KeyCode = Keys.Enter Then OkButton.PerformClick()
        End If
    End Sub

    Public ReadOnly Property downloadLink
        Get
            Return DownloadTextBox.Text
        End Get
    End Property

    Public ReadOnly Property filename
        Get
            Return FilenameTextBox.Text
        End Get
    End Property
End Class