Public Class FileDownload
    Public ip, victimLocation, filepath, filesize As String
    Public id As Integer = (New Random).Next(1, 10000)
    Public nextPart As Boolean = False : Public canceled As Boolean = False
    Sub New(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String, ByVal filesize As String)
        Me.ip = ip : Me.victimLocation = victimLocation : Me.filepath = filepath : Me.filesize = filesize
    End Sub
End Class
