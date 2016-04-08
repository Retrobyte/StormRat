Public Class DialogBox

    Private Sub DialogBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataTextBox.Text = "" : DataTextBox.Focus()
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        If DataTextBox.Text = "" Then
            MessageBox.Show("The text field cannot be left empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Me.DialogResult = DialogResult.OK : Me.Close()
    End Sub

    Private Sub DialogBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Me.ActiveControl.Name = DataTextBox.Name And e.KeyCode = Keys.Enter Then OkButton.PerformClick()
    End Sub

    Public ReadOnly Property inputText
        Get
            Return DataTextBox.Text
        End Get
    End Property
End Class