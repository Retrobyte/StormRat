Public Class Webcam
    Public camList As WebcamDevice
    Sub New(ByVal c As Connection)
        InitializeComponent() : Me.Tag = c : camList = New WebcamDevice(c)
    End Sub

    Private Sub Webcam_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If camList.ShowDialog = DialogResult.OK Then DirectCast(Me.Tag, Connection).Send("StartWebcam|" & camList.index) Else Me.Close()
    End Sub

    Private Sub Webcam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DirectCast(Me.Tag, Connection).Send("StopWebcam|")
    End Sub
End Class