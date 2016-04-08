Public Class FileUpload
    Public ip, victimLocation, filepath As String
    Public id As Integer = (New Random).Next(1, 10000)
    Public nextPart As Boolean = False : Public canceled As Boolean = False
    Sub New(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String)
        Me.ip = ip : Me.victimLocation = victimLocation : Me.filepath = filepath
    End Sub
End Class
