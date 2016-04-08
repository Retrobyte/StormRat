Public Class WebcamDevice
    Public index As String = "0"
    Public cancel As Boolean = True
    Sub New(ByVal c As Connection)
        InitializeComponent() : Me.Tag = c
    End Sub

    Private Sub WebcamDevice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DirectCast(Me.Tag, Connection).Send("GetWebcamList|")
    End Sub

    Private Sub WebcamDevice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cancel Then Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub StartWebcamButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWebcamButton.Click
        If Not WebcamListView.SelectedItems.Count = 0 Then
            index = WebcamListView.FocusedItem.Index.ToString
            Me.DialogResult = Windows.Forms.DialogResult.OK : cancel = False : Me.Close()
        Else
            MessageBox.Show("Please select a webcam from the list.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class