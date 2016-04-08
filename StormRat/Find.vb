Imports System.Net

Public Class Find

    Private Sub Find_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FindTextBox.Text = "" : FindComboBox.SelectedIndex = 0 : FindTextBox.Focus()
    End Sub

    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click
        If FindTextBox.Text = "" Then
            MessageBox.Show("Please make sure all fields are filled in correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.DialogResult = DialogResult.OK : Me.Close()
        End If
    End Sub

    Private Sub Find_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Me.ActiveControl.Name = FindTextBox.Name And e.KeyCode = Keys.Enter Then FindButton.PerformClick()
    End Sub

    Public ReadOnly Property findIndex
        Get
            Return FindComboBox.SelectedIndex
        End Get
    End Property

    Public ReadOnly Property inputText
        Get
            Return FindTextBox.Text
        End Get
    End Property
End Class