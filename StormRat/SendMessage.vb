Public Class SendMessage

    Private Sub SendMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TitleTextBox.Text = "" : MessageTextBox.Text = ""
        InformationRadioButton.Checked = True : QuestionRadioButton.Checked = False
        WarningRadioButton.Checked = False : ErrorRadioButton.Checked = False
        YesNoRadioButton.Checked = True : YesNoCancelRadioButton.Checked = False
        OKRadioButton.Checked = False : OKCancelRadioButton.Checked = False
        RetryCancelRadioButton.Checked = False : AbortRetryCancelRadioButton.Checked = False
        TitleTextBox.Focus()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.DialogResult = DialogResult.OK : Me.Close()
    End Sub

    Public ReadOnly Property messageicon
        Get
            If InformationRadioButton.Checked Then
                Return "1"
            ElseIf QuestionRadioButton.Checked Then
                Return "2"
            ElseIf WarningRadioButton.Checked Then
                Return "3"
            ElseIf ErrorRadioButton.Checked Then
                Return "4"
            Else
                Return "1"
            End If
        End Get
    End Property

    Public ReadOnly Property messagebutton
        Get
            If YesNoRadioButton.Checked Then
                Return "1"
            ElseIf YesNoCancelRadioButton.Checked Then
                Return "2"
            ElseIf OKRadioButton.Checked Then
                Return "3"
            ElseIf OKCancelRadioButton.Checked Then
                Return "4"
            ElseIf RetryCancelRadioButton.Checked Then
                Return "5"
            ElseIf AbortRetryCancelRadioButton.Checked Then
                Return "6"
            Else
                Return "1"
            End If
        End Get
    End Property

    Public ReadOnly Property title
        Get
            Return TitleTextBox.Text
        End Get
    End Property

    Public ReadOnly Property message
        Get
            Return MessageTextBox.Text
        End Get
    End Property
End Class