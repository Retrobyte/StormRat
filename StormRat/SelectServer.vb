Public Class SelectServer

    Private Sub SelectServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FromTextBox.Text = "" : ToTextBox.Text = "" : FromTextBox.Focus()
    End Sub

    Private Sub SelectServer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (Me.ActiveControl.Name = FromTextBox.Name Or Me.ActiveControl.Name = ToTextBox.Name) And e.KeyCode = Keys.Enter Then SelectButton.PerformClick()
    End Sub

    Private Sub FromTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FromTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub ToTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub SelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectButton.Click
        If FromTextBox.Text = "" Or ToTextBox.Text = "" Then
            MessageBox.Show("Please make sure all fields are filled in correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.DialogResult = DialogResult.OK : Me.Close()
        End If
    End Sub

    Public ReadOnly Property fromInt
        Get
            Return CInt(FromTextBox.Text)
        End Get
    End Property

    Public ReadOnly Property toInt
        Get
            Return CInt(ToTextBox.Text)
        End Get
    End Property
End Class