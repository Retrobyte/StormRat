Public Class No_IP_Updater

    Private Sub No_IP_Updater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = "" : PasswordTextBox.Text = "" : HostTextBox.Text = ""
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        If UsernameTextBox.Text.Replace(" ", "") = "" Or PasswordTextBox.Text = "" Or HostTextBox.Text = "" Then
            MessageBox.Show("Please make sure all the fields are filled in correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim wc As New Net.WebClient
        Dim utf8 = New System.Text.UTF8Encoding
        Dim page As String = utf8.GetString(wc.DownloadData("http://dynupdate.no-ip.com/dns?username=" & UsernameTextBox.Text & "&password=" & PasswordTextBox.Text & "&hostname=" & HostTextBox.Text))
        Dim result() As String = page.Split(":")
        If result(1).Contains("0") Then
            MessageBox.Show("IP address is current, no update performed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("1") Then
            MessageBox.Show("DNS hostname update successful.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("2") Then
            MessageBox.Show("Hostname supplied does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("3") Then
            MessageBox.Show("Invalid username.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("4") Then
            MessageBox.Show("Invalid password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("5") Then
            MessageBox.Show("Too many updates sent. Updates are blocked until 1 hour passes since last status of 5 returned.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("6") Then
            MessageBox.Show("Account disabled due to violation of No-IP terms of service. Our terms of service can be viewed at http://www.no-ip.com/legal/tos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("7") Then
            MessageBox.Show("Invalid IP. Invalid IP submitted is improperly formated, is a private LAN RFC 1918 address, or an abuse blacklisted address.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("8") Then
            MessageBox.Show("Disabled / Locked hostname.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("9") Then
            MessageBox.Show("Host updated is configured as a web redirect and no update was performed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("10") Then
            MessageBox.Show("Group supplied does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("11") Then
            MessageBox.Show("DNS group update is successful.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("12") Then
            MessageBox.Show("DNS group is current, no update performed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("13") Then
            MessageBox.Show("Update client support not available for supplied hostname or group.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("14") Then
            MessageBox.Show("Hostname supplied does not have offline settings configured. Returned if sending offline=YES on a host that does not have any offline actions configured.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("99") Then
            MessageBox.Show("Client disabled. Client should exit and not perform any more updates without user intervention.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result(1).Contains("100") Then
            MessageBox.Show("User input error usually returned if missing required request parameters.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class