Public Class Script

    Private Sub Script_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScriptTextBox.Text = "" : ScriptTextBox.Focus()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If ScriptTextBox.Text.Replace(" ", "") = "" Then Exit Sub
        Me.DialogResult = DialogResult.OK : Me.Close()
    End Sub

    Public ReadOnly Property scriptText
        Get
            Return ScriptTextBox.Text
        End Get
    End Property
End Class