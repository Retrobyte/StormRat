Public Class RemoteDesktop
    Dim shift As Boolean = False : Dim ctrl As Boolean = False : Dim alt As Boolean = False
    Sub New(ByVal c As Connection)
        InitializeComponent() : Me.Tag = c
    End Sub

    Private Sub EnableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem.Click
        AddHandler Me.KeyDown, AddressOf RemoteDesktop_KeyDown : AddHandler Me.KeyUp, AddressOf RemoteDesktop_KeyUp : DisableToolStripMenuItem.Enabled = True : EnableToolStripMenuItem.Enabled = False
    End Sub

    Private Sub DisableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem.Click
        RemoveHandler Me.KeyDown, AddressOf RemoteDesktop_KeyDown : RemoveHandler Me.KeyUp, AddressOf RemoteDesktop_KeyUp : DisableToolStripMenuItem.Enabled = False : EnableToolStripMenuItem.Enabled = True
    End Sub

    Sub RemoteDesktop_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If ConvertKeycode(Convert.ToInt32(ChrW(e.KeyCode))).ToLower = "shiftkey" Then shift = True
        If ConvertKeycode(Convert.ToInt32(ChrW(e.KeyCode))).ToLower = "ctrl" Then ctrl = True
        If ConvertKeycode(Convert.ToInt32(ChrW(e.KeyCode))).ToLower = "menu" Then alt = True
    End Sub

    Private Sub RemoteDesktop_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If ConvertKeycode(Convert.ToInt32(ChrW(e.KeyCode))).ToLower = "shiftkey" Then shift = False : Exit Sub
        If ConvertKeycode(Convert.ToInt32(ChrW(e.KeyCode))).ToLower = "ctrl" Then ctrl = False : Exit Sub
        If ConvertKeycode(Convert.ToInt32(ChrW(e.KeyCode))).ToLower = "menu" Then alt = False : Exit Sub
        Dim Code As String = ConvertKeycode(Convert.ToInt32(ChrW(e.KeyCode))).ToLower
        If Code = "capital" Then Exit Sub
        Select Case Code
            Case "d1"
                Code = "1"
            Case "d2"
                Code = "2"
            Case "d3"
                Code = "3"
            Case "d4"
                Code = "4"
            Case "d5"
                Code = "5"
            Case "d6"
                Code = "6"
            Case "d7"
                Code = "7"
            Case "d8"
                Code = "8"
            Case "d9"
                Code = "9"
            Case "d0"
                Code = "0"
            Case "d!"
                Code = "!"
            Case "d@"
                Code = "@"
            Case "d#"
                Code = "#"
            Case "d$"
                Code = "$"
            Case "d%"
                Code = "%"
            Case "d^"
                Code = "^"
            Case "d&"
                Code = "&"
            Case "d*"
                Code = "*"
            Case "d("
                Code = "("
            Case "d)"
                Code = ")"
            Case "oemminus"
                Code = "-"
            Case "oemplus"
                Code = "="
            Case "oemopenbrackets"
                Code = "["
            Case "oem6"
                Code = "]"
            Case "oem5"
                Code = "\"
            Case "oem1"
                Code = ";"
            Case "oem7"
                Code = "'"
            Case "oemcomma"
                Code = ","
            Case "oemperiod"
                Code = "."
            Case "oemquestion"
                Code = "/"
            Case "printscreen"
                Code = "prtsc"
            Case "pageup"
                Code = "pgup"
            Case "next"
                Code = "pgdn"
            Case "scroll"
                Code = "scrolllock"
        End Select
        If ctrl Then
            If alt Then
                If shift Then
                    DirectCast(Me.Tag, Connection).Send("SendKeys|^(%(+(" & Code & ")))")
                Else
                    DirectCast(Me.Tag, Connection).Send("SendKeys|^(%(" & Code & "))")
                End If
            Else
                If shift Then
                    DirectCast(Me.Tag, Connection).Send("SendKeys|^(+(" & Code & "))")
                Else
                    DirectCast(Me.Tag, Connection).Send("SendKeys|^(" & Code & ")")
                End If
            End If
        Else
            If alt Then
                If shift Then
                    DirectCast(Me.Tag, Connection).Send("SendKeys|%(+(" & Code & "))")
                Else
                    DirectCast(Me.Tag, Connection).Send("SendKeys|%(" & Code & ")")
                End If
            Else
                If shift Then
                    DirectCast(Me.Tag, Connection).Send("SendKeys|+(" & Code & ")")
                Else
                    DirectCast(Me.Tag, Connection).Send("SendKeys|" & Code)
                End If
            End If
        End If
    End Sub

    Private Sub EnableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem1.Click
        AddHandler DesktopPictureBox.MouseMove, AddressOf RemoteDesktop_MouseMove : DisableToolStripMenuItem1.Enabled = True : EnableToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub DisableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem1.Click
        RemoveHandler DesktopPictureBox.MouseMove, AddressOf RemoteDesktop_MouseMove : DisableToolStripMenuItem1.Enabled = False : EnableToolStripMenuItem1.Enabled = True
    End Sub

    Private Sub RemoteDesktop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim coordinates As String = DesktopPictureBox.Size.ToString
        Dim x As Double = e.X / CInt(coordinates.Substring(7, coordinates.IndexOf(",") - 7))
        Dim y As Double = e.Y / CInt(coordinates.Substring(coordinates.IndexOf(",") + 9).Trim("}"))
        DirectCast(Me.Tag, Connection).Send("MoveMouse|" & x.ToString & "|" & y.ToString)
    End Sub

    Private Sub EnableToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem2.Click
        AddHandler DesktopPictureBox.MouseDown, AddressOf RemoteDesktop_MouseDown : AddHandler DesktopPictureBox.MouseUp, AddressOf RemoteDesktop_MouseUp : DisableToolStripMenuItem2.Enabled = True : EnableToolStripMenuItem2.Enabled = False
    End Sub

    Private Sub DisableToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem2.Click
        RemoveHandler DesktopPictureBox.MouseDown, AddressOf RemoteDesktop_MouseDown : RemoveHandler DesktopPictureBox.MouseUp, AddressOf RemoteDesktop_MouseUp : DisableToolStripMenuItem2.Enabled = False : EnableToolStripMenuItem2.Enabled = True
    End Sub

    Private Sub RemoteDesktop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim coordinates As String = DesktopPictureBox.Size.ToString
        Dim x As Double = e.X / CInt(coordinates.Substring(7, coordinates.IndexOf(",") - 7))
        Dim y As Double = e.Y / CInt(coordinates.Substring(coordinates.IndexOf(",") + 9).Trim("}"))
        If e.Button = MouseButtons.Left Then
            DirectCast(Me.Tag, Connection).Send("LClickDown|" & x.ToString & "|" & y.ToString)
        ElseIf e.Button = MouseButtons.Right Then
            DirectCast(Me.Tag, Connection).Send("RClickDown|" & x.ToString & "|" & y.ToString)
        End If
    End Sub

    Private Sub RemoteDesktop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Dim coordinates As String = DesktopPictureBox.Size.ToString
        Dim x As Double = e.X / CInt(coordinates.Substring(7, coordinates.IndexOf(",") - 7))
        Dim y As Double = e.Y / CInt(coordinates.Substring(coordinates.IndexOf(",") + 9).Trim("}"))
        If e.Button = MouseButtons.Left Then
            DirectCast(Me.Tag, Connection).Send("LClickUp|" & x.ToString & "|" & y.ToString)
        ElseIf e.Button = MouseButtons.Right Then
            DirectCast(Me.Tag, Connection).Send("RClickUp|" & x.ToString & "|" & y.ToString)
        End If
    End Sub

    Private Sub RemoteDesktop_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DirectCast(Me.Tag, Connection).Send("StopDesktop|")
    End Sub

    Function ConvertKeycode(ByVal KeyCode As Integer) As String
        Dim Key As Keys = DirectCast(KeyCode, Keys)
        Select Case Key
            Case Keys.Back
                Return "back"
            Case Keys.ControlKey
                Return "ctrl"
            Case Keys.Alt
                Return "alt"
            Case Keys.Return
                Return "return"
            Case Keys.Space
                Return "space"
            Case Keys.Shift
                Return "shift"
            Case Else
                Return Key.ToString
        End Select
    End Function
End Class