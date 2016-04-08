Public Class ProcessManager
    Public suspendedList As New ArrayList
    Sub New(ByVal c As Connection)
        InitializeComponent() : Me.Tag = c
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        DirectCast(Me.Tag, Connection).Send("GetProcesses|")
    End Sub

    Private Sub ResumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeToolStripMenuItem.Click
        Dim allprocess As String = ""
        For Each item As ListViewItem In ProcessListView.SelectedItems
            If item.BackColor = Color.Red Then
                allprocess += (item.Text & "ProcessSplit")
                suspendedList.Remove(item.SubItems(1).Text)
                item.BackColor = Color.White
            End If
        Next
        DirectCast(Me.Tag, Connection).Send("ResumeProcess|" & allprocess)
    End Sub

    Private Sub SuspendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspendToolStripMenuItem.Click
        Dim allprocess As String = ""
        For Each item As ListViewItem In ProcessListView.SelectedItems
            If Not item.BackColor = Color.Red Then
                item.BackColor = Color.Red
                suspendedList.Add(item.SubItems(1).Text)
                allprocess += (item.Text & "ProcessSplit")
            End If
        Next
        DirectCast(Me.Tag, Connection).Send("SuspendProcess|" & allprocess)
    End Sub

    Private Sub KillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillToolStripMenuItem.Click
        Dim allprocess As String = ""
        For Each item As ListViewItem In ProcessListView.SelectedItems
            allprocess += (item.Text & "ProcessSplit")
        Next
        DirectCast(Me.Tag, Connection).Send("KillProcess|" & allprocess)
        Delay(1) : RefreshToolStripMenuItem.PerformClick()
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
End Class