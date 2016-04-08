Public Class ChatSystem

    Sub New(ByVal c As Connection)
        InitializeComponent() : Me.Tag = c
    End Sub

    Private Sub ChatSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.ActiveControl.Name = SendTextBox.Name Then SendButton.PerformClick()
        End If
    End Sub

    Private Sub ChatSystem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DirectCast(Me.Tag, Connection).Send("StopChatSystem|")
    End Sub

    Private Sub ChatTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChatTextBox.TextChanged
        ChatTextBox.SelectionStart = ChatTextBox.TextLength : ChatTextBox.ScrollToCaret()
    End Sub

    Private Sub SendButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendButton.Click
        If SendTextBox.Text.Replace(" ", "") = "" Then Exit Sub
        DirectCast(Me.Tag, Connection).Send("Chat|" & SendTextBox.Text)
        ChatTextBox.Text += "[" & TimeOfDay & "] You: " & vbNewLine & SendTextBox.Text & vbNewLine & vbNewLine
        SendTextBox.Clear()
    End Sub
End Class